using Org.BouncyCastle.Asn1.Cmp;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.View.Forms;

namespace VehicleManagementSystem.UserControls {
    public partial class ucBookingCard : UserControl {
        public string BookingID { get; private set; }
        public BookingDto bookingData { get; private set; } 
        public ucBookingCard() {
            InitializeComponent();
            this.Cursor = Cursors.Hand;
        }

        public void BindData(BookingDto booking) {
            if (booking == null) return;

            BookingID = booking.BookingID;
            bookingData = booking;

            lblBookingID.Text = $"ID: {booking.BookingID}";
            lblCustomerName.Text = $"{booking.FirstName} {booking.LastName}";
            lblVehicle.Text = booking.VehicleName ?? "Unknown Vehicle";
            lblDateSubmitted.Text = booking.DateSubmitted.GetTimeAgo();

            // Determine which price to show based on status
            // Use Trim() and ToUpper() to avoid casing/spacing bugs
            string currentStatus = booking.Status?.Trim() ?? "";

            if (currentStatus.Equals("Completed", StringComparison.OrdinalIgnoreCase)) {
                lblPrice.Text = $"Total: ₱ {booking.TotalPrice:N2}";
            } else {
                // For 'Reserved', 'Out', etc., show Projected Price
                lblPrice.Text = $"Total: ₱ {booking.ProjectedPrice:N2}";
            }

            lblDates.Text = $"{booking.DateSchedOut:MMM dd hh:mm tt} - {booking.DateDue:MMM dd, yyyy hh:mm tt}";

            UpdateStatusUI(booking.Status);
        }

        private void UpdateStatusUI(string status) {
            lblStatus.Text = status.ToUpper();

            // Modern palette for white theme
            switch (status.ToLower()) {
                case "completed":
                    sideStatusPanel.FillColor = Color.FromArgb(46, 204, 113); // Emerald Green
                    lblStatus.ForeColor = Color.FromArgb(46, 204, 113);
                    break;
                case "pending":
                    sideStatusPanel.FillColor = Color.FromArgb(241, 196, 15); // Sun Flower Yellow
                    lblStatus.ForeColor = Color.FromArgb(180, 140, 0); 
                    break;
                case "rejected":
                    sideStatusPanel.FillColor = Color.FromArgb(231, 76, 60); // Alizarin Red
                    lblStatus.ForeColor = Color.FromArgb(231, 76, 60);
                    break;
                case "approved":
                    sideStatusPanel.FillColor = Color.FromArgb(52, 152, 219); // Peter River Blue
                    lblStatus.ForeColor = Color.FromArgb(52, 152, 219);
                    break;
                case "ongoing":
                    sideStatusPanel.FillColor = Color.FromArgb(155, 89, 182); // Amethyst Purple
                    lblStatus.ForeColor = Color.FromArgb(155, 89, 182);
                    break;
                default:
                    sideStatusPanel.FillColor = Color.Gainsboro;
                    lblStatus.ForeColor = Color.Gray;
                    break;
            }
        }

        public void ChangeBtnViewText(string newText)
        {
            btnView.Text = newText;
        }

        private void btnViewDetails_Click(object sender, EventArgs e) {
            // Code to open the full edit/view form for this BookingID

            if(lblStatus.Text == "PENDING")
            {
                NavigationHelper.OpenForm(new frmPendingBooking(bookingData));
            } else if (lblStatus.Text == "APPROVED") {
                NavigationHelper.OpenForm(new frmApprovedBooking(bookingData));
            } else if (lblStatus.Text == "ONGOING") {
                NavigationHelper.OpenForm(new frmOngoingBooking(bookingData));
            } else if (lblStatus.Text == "COMPLETED") {
                NavigationHelper.OpenForm(new frmCompletedBooking(bookingData));
            }

        }
    }
}
