using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using System.IO;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.Services;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmOngoingBooking : Form {
        // Core State
        private BookingDto originalBooking;
        private PendingInfosDto currentPendingInfo;
        private BookingServices db = new BookingServices();

        // Inspection State
        private List<string> selectedPaths = new List<string>();

        public frmOngoingBooking(BookingDto origBooking) {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            SetupEvents();
            DisplayBookingDetails(origBooking);
        }

        private void SetupEvents() {
            // Calculation trigger
            additionalFeesTextBox.TextChanged += (s, e) => UpdateTotalDisplay();

            // Image handling
            btnUploadImages.Click += (s, e) => TriggerImageUpload();

            // Finalize action
            finalizeBtn.Click += (s, e) => FinalizeInspection();
        }

        public void DisplayBookingDetails(BookingDto b) {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = BookingHelpers.MapToPendingInfo(b);

            // Header & IDs
            lblBookingIDValue.Text = currentPendingInfo.BookingID.ToString();
            lblDateofRequestValue.Text = BookingHelpers.GetFormattedDate(currentPendingInfo.DateSubmitted);

            // Customer Info
            firstNameTextBox.Text = currentPendingInfo.FirstName;
            lastNameTextBox.Text = currentPendingInfo.LastName;
            customerLicenseTextBox.Text = currentPendingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentPendingInfo.Email;
            customerContactNumTextBox.Text = currentPendingInfo.PhoneNumber;

            // Vehicle Info
            vehicleLicenseTextBox.Text = currentPendingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentPendingInfo.VehicleName;

            // Display Outbound State (What the car looked like when it left)
            // Assuming these are mapped in your DTO
            currentFuelLevelTextBox.Text = b.FuelLevelOut ?? "---";
            currentOdometerTextBox.Text = b.MileageOut?.ToString() ?? "---";

            // Rental Schedule & Financials
            rentalDateStartDTP.Value = currentPendingInfo.DateSchedOut;
            rentalDateEndDTP.Value = currentPendingInfo.DateDue;
            lblPriceValue.Text = "₱" + currentPendingInfo.ProjectedPrice.ToString("N2");
            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            // Vehicle Image
            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.default_car_model;

            UpdateTotalDisplay();
        }

        #region Inspection & Calculation Logic

        private void UpdateTotalDisplay() {
            if (currentPendingInfo == null) return;

            decimal basePrice = currentPendingInfo.ProjectedPrice;
            decimal additionalFees = 0;

            if (decimal.TryParse(additionalFeesTextBox.Text, out decimal fees)) {
                additionalFees = fees;
            }

            lblTotalPriceValue.Text = "₱" + (basePrice + additionalFees).ToString("N2");
        }

        // Notice the 'async' keyword added here to handle your Task<bool> service method
        // Notice the 'async' keyword added here to handle your Task<bool> service method
        private async void FinalizeInspection() {
            if (currentPendingInfo == null) return;

            // --- 1. VALIDATION: Mileage & Fuel ---
            if (!int.TryParse(odometerOnReturnTextBox.Text, out int mileageIn) || mileageIn <= 0) {
                MessageBox.Show("Please enter a valid return mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                odometerOnReturnTextBox.Focus();
                return;
            }

            // Odometer strict check: return mileage cannot be lower than outbound mileage
            if (int.TryParse(currentOdometerTextBox.Text, out int mileageOut) && mileageIn < mileageOut) {
                MessageBox.Show($"Return mileage ({mileageIn}) cannot be lower than the outbound mileage ({mileageOut}).",
                                "Invalid Odometer Reading", MessageBoxButtons.OK, MessageBoxIcon.Error);
                odometerOnReturnTextBox.Focus();
                return;
            }

            string fuelIn = fuelLevelOnReturnTextBox.Text.Trim();
            if (string.IsNullOrEmpty(fuelIn)) {
                MessageBox.Show("Please enter the return fuel level.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                fuelLevelOnReturnTextBox.Focus();
                return;
            }

            // --- 2. Image Validation ---
            if (selectedPaths.Count == 0) {
                MessageBox.Show("At least one inspection image is required.", "Validation", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                if (!TriggerImageUpload()) return;
            }

            // --- 3. Date Match Validation (Warning) ---
            if (rentalDateEndDTP.Value.Date != DateTime.Today) {
                DialogResult dateWarning = MessageBox.Show(
                    $"The scheduled return date is {rentalDateEndDTP.Value:MMM dd, yyyy}, but today is {DateTime.Today:MMM dd, yyyy}.\n\nDo you want to proceed with finalizing the booking?",
                    "Date Mismatch Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dateWarning == DialogResult.No) {
                    return; // User canceled because of the date mismatch
                }
            }

            // --- 4. Final Confirmation & Processing ---
            if (MessageBox.Show("Finalize inspection and save images?", "Confirm", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                try {
                    List<string> relativePathsForDb = new List<string>();
                    string baseFolder = Path.Combine(Environment.GetFolderPath(Environment.SpecialFolder.ApplicationData), "CarRentalApp", "Images", "Inspections");

                    if (!Directory.Exists(baseFolder))
                        Directory.CreateDirectory(baseFolder);

                    foreach (string tempPath in selectedPaths) {
                        string extension = Path.GetExtension(tempPath);
                        string safeId = string.Concat(currentPendingInfo.BookingID.Split(Path.GetInvalidFileNameChars()));
                        string fileName = $"insp_{safeId}_{DateTime.Now:yyyyMMdd_HHmmss}_{Guid.NewGuid().ToString().Substring(0, 4)}{extension}";

                        string destinationPath = Path.Combine(baseFolder, fileName);
                        string dbPath = Path.Combine("Images", "Inspections", fileName);

                        File.Copy(tempPath, destinationPath, true);
                        relativePathsForDb.Add(dbPath);
                    }

                    // --- 5. Save to Database ---
                    bool success = await db.SaveFullInspection(
                        currentPendingInfo.BookingID,
                        currentPendingInfo.VehicleVIN,
                        inspectionNotesTextBox.Text.Trim(),
                        damageReportTextBox.Text.Trim(),
                        relativePathsForDb,
                        mileageIn,
                        fuelIn
                    );

                    if (success) {
                        MessageBox.Show("Inspection data, images, and vehicle status updated successfully!", "Success");
                        NavigationHelper.OpenForm(new frmOutbound());
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"File or Database error: {ex.Message}", "Process Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        #endregion

        #region Image Gallery Methods

        private bool TriggerImageUpload() {
            using (OpenFileDialog ofd = new OpenFileDialog { Multiselect = true, Filter = "Images|*.jpg;*.png;*.jpeg" }) {
                if (ofd.ShowDialog() == DialogResult.OK) {
                    foreach (string path in ofd.FileNames) {
                        if (!selectedPaths.Contains(path)) {
                            selectedPaths.Add(path);
                            AddThumbnail(path);
                        }
                    }
                    return true;
                }
            }
            return false;
        }

        private void AddThumbnail(string path) {
            PictureBox pic = new PictureBox {
                Size = new Size(100, 80),
                SizeMode = PictureBoxSizeMode.Zoom,
                Image = Image.FromFile(path),
                Margin = new Padding(3),
                BorderStyle = BorderStyle.FixedSingle
            };

            // Double click to remove
            pic.DoubleClick += (s, e) => {
                flpThumbnails.Controls.Remove(pic);
                selectedPaths.Remove(path);
                pic.Dispose();
            };

            flpThumbnails.Controls.Add(pic);
        }

        #endregion

        private void backBtn_Click(object sender, EventArgs e) {
            if (originalBooking.Status == "Approved") {
                NavigationHelper.OpenForm(new frmOutbound());
            } else if (originalBooking.Status == "Ongoing") {
                NavigationHelper.OpenForm(new frmInbound());
            } else if (originalBooking.Status != "Approved" ||  originalBooking.Status != "Ongoing") {
                NavigationHelper.OpenForm(new frmBookings());
            }
        }
    }
}