using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using System.IO;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Helpers;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms
{
    public partial class frmApprovedBooking : Form
    {
        private BookingDto originalBooking;
        private PendingInfosDto currentPendingInfo;
        private bool isSyncing = false;
        private BookingServices db = new BookingServices();

        public frmApprovedBooking(BookingDto origBooking)
        {
            this.AutoScaleMode = AutoScaleMode.None;
            InitializeComponent();
            DisplayBookingDetails(origBooking);
        }

        public void DisplayBookingDetails(BookingDto b)
        {
            if (b == null) return;

            originalBooking = b;
            currentPendingInfo = BookingHelpers.MapToPendingInfo(b);

            // Populate UI
            lblBookingIDValue.Text = currentPendingInfo.BookingID.ToString();
            firstNameTextBox.Text = currentPendingInfo.FirstName;
            lastNameTextBox.Text = currentPendingInfo.LastName;
            customerLicenseTextBox.Text = currentPendingInfo.LicenseNumber;
            customerEmailTextBox.Text = currentPendingInfo.Email;
            customerContactNumTextBox.Text = currentPendingInfo.PhoneNumber;
            lblDateofRequestValue.Text = BookingHelpers.GetFormattedDate(currentPendingInfo.DateSubmitted);
            vehicleLicenseTextBox.Text = currentPendingInfo.LicensePlate;
            vehicleNameTextBox.Text = currentPendingInfo.VehicleName;
            currentFuelLevelTextBox.Clear();
            currentOdometerTextBox.Text = currentPendingInfo.CurrentOdometerReading.ToString();
            isSyncing = true;
            rentalDateStartDTP.Value = currentPendingInfo.DateSchedOut;
            rentalDateEndDTP.Value = currentPendingInfo.DateDue;
            lblPriceValue.Text = "₱" + currentPendingInfo.ProjectedPrice.ToString("N2");
            isSyncing = false;

            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(currentPendingInfo.DateSchedOut, currentPendingInfo.DateDue);

            if (!string.IsNullOrEmpty(currentPendingInfo.FullImagePath) && File.Exists(currentPendingInfo.FullImagePath))
                vehiclePictureBox.ImageLocation = currentPendingInfo.FullImagePath;
            else
                vehiclePictureBox.Image = Properties.Resources.default_car_model;

            RefreshConflictSection();
        }

        #region Validation & Logic extraction

        private (List<BookingDto> HardDirect, List<BookingDto> BufferOverlaps, List<BookingDto> Pending) ClassifyConflicts(PendingInfosDto pending, List<BookingDto> conflicts)
        {
            // Statuses that are already "locked in" the calendar
            var activeStatuses = new[] { "Reserved", "Out", "Approved" };

            var hardDirect = conflicts.Where(c => activeStatuses.Contains(c.Status) && pending.DateSchedOut < c.DateDue).ToList();

            // 3-hour buffer check (if pickup is within 3 hours after another booking's return)
            var bufferOverlaps = conflicts.Where(c => pending.DateSchedOut >= c.DateDue && pending.DateSchedOut <= c.DateDue.AddHours(3)).ToList();

            var pendingList = conflicts.Where(c => c.Status == "Pending").ToList();

            return (hardDirect, bufferOverlaps, pendingList);
        }

        #endregion

        public void rentalDate_ValueChanged(object sender, EventArgs e)
        {
            if (currentPendingInfo == null || isSyncing) return;
            try
            {
                isSyncing = true;
                currentPendingInfo.DateSchedOut = rentalDateStartDTP.Value;
                currentPendingInfo.DateDue = rentalDateEndDTP.Value;
                RefreshConflictSection();
            }
            finally { isSyncing = false; }
        }

        private void RefreshConflictSection()
        {
            if (currentPendingInfo == null) return;

            // 1. Validation Check
            if (!IsDatePeriodValid(out _))
            {
                lblRentalTimeValue.Text = "Invalid Data";
                lblRentalTimeValue.ForeColor = Color.Red;
                lblPriceValue.Text = "₱0.00";
                conflictFlowPanel.Controls.Clear();
                lblBookingConflicts.Visible = false;
                return;
            }

            // 2. Update UI Labels
            lblRentalTimeValue.ForeColor = Color.Black;
            decimal newPrice = CalculateProjectedPrice(rentalDateStartDTP.Value, rentalDateEndDTP.Value, currentPendingInfo.DailyRate);
            lblPriceValue.Text = "₱" + newPrice.ToString("N2");
            currentPendingInfo.ProjectedPrice = newPrice;
            lblRentalTimeValue.Text = BookingHelpers.GetRentalDuration(rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            // 3. Clear existing controls to start fresh
            conflictFlowPanel.Controls.Clear();

            // 4. Fetch Conflicts
            var conflicts = BookingServices.GetConflictingBookings(
                currentPendingInfo.BookingID, currentPendingInfo.VehicleVIN,
                rentalDateStartDTP.Value, rentalDateEndDTP.Value);

            if (conflicts != null && conflicts.Count > 0)
            {
                // CONFLICTS EXIST
                lblBookingConflicts.Visible = true;
                lblNoBookingConflicts.Visible = false; // Explicitly hide the "No Conflict" label

                foreach (var conflict in conflicts)
                {
                    ucBookingCard miniCard = new ucBookingCard();
                    miniCard.BindData(conflict);
                    // Ensure the card itself doesn't have huge margins that push things out of view
                    conflictFlowPanel.Controls.Add(miniCard);
                }
            }
            else
            {
                // NO CONFLICTS
                lblBookingConflicts.Visible = false;

                // Add the label back to the cleared panel and show it
                conflictFlowPanel.Controls.Add(lblNoBookingConflicts);
                lblNoBookingConflicts.Visible = true;
            }
        }

        private bool IsDatePeriodValid(out string errorMessage)
        {
            errorMessage = string.Empty;
            if (rentalDateEndDTP.Value <= rentalDateStartDTP.Value)
            {
                errorMessage = "Return date must be after the pickup date.";
                return false;
            }
            return true;
        }

        private decimal CalculateProjectedPrice(DateTime start, DateTime end, decimal dailyRate)
        {
            TimeSpan duration = end - start;
            if (duration.TotalSeconds <= 0) return 0;
            int totalDays = (int)Math.Ceiling(duration.TotalHours / 24.0);
            return totalDays * dailyRate;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            NavigationHelper.OpenForm(new frmOutbound());
        }

        private void releaseBtn_Click(object sender, EventArgs e) {
            // 1. Basic Selection Check
            if (currentPendingInfo == null) {
                MessageBox.Show("Please select a reserved booking first.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Validation: Mileage
            if (!int.TryParse(currentOdometerTextBox.Text, out int mOut) || mOut <= 0) {
                MessageBox.Show("Please enter a valid starting mileage.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentOdometerTextBox.Focus();
                return;
            }

            // 3. Validation: Fuel Level
            string fOut = currentFuelLevelTextBox.Text.Trim();
            if (string.IsNullOrEmpty(fOut)) {
                MessageBox.Show("Please indicate the starting fuel level (e.g., Full, 75%, etc.).", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                currentFuelLevelTextBox.Focus();
                return;
            }

            if (currentPendingInfo.DateSchedOut.Date != DateTime.Today) {
                string dateWarn = $"⚠️ DATE MISMATCH:\n\n" +
                                  $"This booking is scheduled for: {currentPendingInfo.DateSchedOut:MMM dd, yyyy}\n" +
                                  $"Today's Date: {DateTime.Today:MMM dd, yyyy}\n\n" +
                                  "Are you sure you want to release this unit early/late?";

                DialogResult dateResult = MessageBox.Show(dateWarn, "Schedule Warning",
                                          MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                if (dateResult == DialogResult.No) return;
            }

            // 4. Confirmation
            string msg = $"Release vehicle {currentPendingInfo.LicensePlate} to {currentPendingInfo.FirstName}?\n" +
                         $"Starting Mileage: {mOut} km\n" +
                         $"Fuel Level: {fOut}";

            if (MessageBox.Show(msg, "Confirm Release", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes) {
                var result = db.ProcessUnitRelease(
                    currentPendingInfo.BookingID,
                    currentPendingInfo.VehicleVIN,
                    mOut,
                    fOut
                );

                if (result.success) {
                    MessageBox.Show(result.message, "Unit Released", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigationHelper.OpenForm(new frmOutbound());
                } else {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            // 1. Check if a booking is actually selected
            if (currentPendingInfo == null) {
                MessageBox.Show("Please select a booking to cancel.", "Selection Required", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }

            // 2. Double Confirmation
            string msg = $"Are you sure you want to cancel the booking for {currentPendingInfo.FirstName} {currentPendingInfo.LastName}?\n\n" +
                         "This will mark the status as 'Rejected'.";

            if (MessageBox.Show(msg, "Confirm Cancellation", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes) {
                // 3. Reuse your existing ProcessRejection method
                var result = db.ProcessRejection(currentPendingInfo.BookingID);

                if (result.success) {
                    MessageBox.Show("Booking has been successfully cancelled.", "Cancelled", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    NavigationHelper.OpenForm(new frmOutbound());
                } else {
                    MessageBox.Show(result.message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
