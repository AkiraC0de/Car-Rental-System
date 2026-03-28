using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.Services;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmCompletedBooking : Form {
        private BookingDto originalBooking;
        private PendingInfosDto currentPendingInfo;
        private BookingServices db = new BookingServices();

        public frmCompletedBooking(BookingDto origBooking) {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();

            // Set UI to Read-Only mode
            SetFieldsReadOnly();

            DisplayBookingDetails(origBooking);
        }

        private void SetFieldsReadOnly() {
            // Disable inputs since this is a historical record
            fuelLevelOnReturnTextBox.ReadOnly = true;
            odometerOnReturnTextBox.ReadOnly = true;
            inspectionNotesTextBox.ReadOnly = true;
            damageReportTextBox.ReadOnly = true;

            // Hide action buttons that don't belong here
        }

        public async void DisplayBookingDetails(BookingDto b) {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = BookingHelpers.MapToPendingInfo(b);

            // Basic Header & IDs
            lblBookingIDValue.Text = currentPendingInfo.BookingID.ToString();
            lblDateofRequestValue.Text = BookingHelpers.GetFormattedDate(currentPendingInfo.DateSubmitted);

            // Customer & Vehicle Info
            firstNameTextBox.Text = currentPendingInfo.FirstName;
            lastNameTextBox.Text = currentPendingInfo.LastName;
            customerLicenseTextBox.Text = currentPendingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentPendingInfo.Email;
            customerContactNumTextBox.Text = currentPendingInfo.PhoneNumber;
            vehicleLicenseTextBox.Text = currentPendingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentPendingInfo.VehicleName;

            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.default_car_model;

            // Outbound State (When it left)
            currentFuelLevelTextBox.Text = b.FuelLevelOut ?? "---";
            currentOdometerTextBox.Text = b.MileageOut?.ToString() ?? "---";

            // Return State (The "In" data from Bookings table)
            fuelLevelOnReturnTextBox.Text = b.FuelLevelIn ?? "---";
            odometerOnReturnTextBox.Text = b.MileageIn?.ToString() ?? "---";

            // Load Inspection & Damage Data
            // Note: We'll need to create this method in BookingServices next
            var details = await db.GetFullInspectionDetails(b.BookingID);
            if (details != null) {
                inspectionNotesTextBox.Text = details.GeneralNotes;
                damageReportTextBox.Text = details.DamageDescriptions;
                
                LoadInspectionThumbnails(details.ImagePaths);
            }

            // Financials
            lblPriceValue.Text = "₱" + currentPendingInfo.ProjectedPrice.ToString("N2");
            // Assuming AdditionalFees is a column in your Bookings table
           
            UpdateTotalDisplay(b.AdditionalFees ?? 0);
        }

        private void UpdateTotalDisplay(decimal fees) {
            decimal basePrice = currentPendingInfo.TotalPrice;
            lblTotalPriceValue.Text = "₱" + (basePrice + fees).ToString("N2");
        }

        private void LoadInspectionThumbnails(List<string> imagePaths) {
            flpThumbnails.Controls.Clear();
            string appDataPath = Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData);

            // The base folder where your app stores everything
            string baseFolder = Path.Combine(appDataPath, "CarRentalApp");

            foreach (string relativePath in imagePaths) {
                // relativePath is "Images\Inspections\file.png"
                // baseFolder is "C:\Users\Name\AppData\Roaming\CarRentalApp"
                string fullPath = Path.Combine(baseFolder, relativePath);

                PictureBox pic = new PictureBox {
                    Size = new Size(120, 90),
                    SizeMode = PictureBoxSizeMode.Zoom,
                    Margin = new Padding(5),
                    BorderStyle = BorderStyle.FixedSingle,
                    Cursor = Cursors.Hand
                };

                if (File.Exists(fullPath)) {
                    // Use Image.FromStream to avoid locking the file on disk
                    using (var stream = new FileStream(fullPath, FileMode.Open, FileAccess.Read)) {
                        pic.Image = Image.FromFile(fullPath);
                    }

                    pic.Click += (s, e) => {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fullPath) {
                            UseShellExecute = true
                        });
                    };
                } else {
                    pic.Image = Properties.Resources.default_car_model;
                    Console.WriteLine($"MISSING FILE: {fullPath}");
                }

                flpThumbnails.Controls.Add(pic);
            }
        }

        private void backBtn_Click(object sender, EventArgs e) {
            NavigationHelper.OpenForm(new frmBookings());
        }
    }
}