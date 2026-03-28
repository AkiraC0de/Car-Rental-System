using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmOutbound : Form {
        private ucLoadingOverlay _loader;
        private BookingServices _db;

        // --- Search Debounce Fields ---
        private Timer searchDebounceTimer;

        public frmOutbound() {
            InitializeComponent();
            InitializeFirstLoad();
            SetupSearchTimer();
        }

        private void SetupSearchTimer() {
            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350; // Wait 350ms after last keystroke
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
        }

        private void InitializeFirstLoad() {
            _db = new BookingServices();
            _loader = new ucLoadingOverlay();
            this.Resize += (s, e) => LayoutFlowLayoutPanel();

            // Initial fetch
            _ = RefreshOutboundList();
        }

        #region Search Logic

        // Link this to your Guna2TextBox TextChanged event in the Designer
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private async void SearchDebounceTimer_Tick(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            await RefreshOutboundList();
        }

        private async Task RefreshOutboundList() {
            string term = searchBox.Text.Trim();

            _loader.ShowLoading(panelLoading);
            panelLoading.BringToFront();

            try {
                List<BookingDto> bookings;

                if (string.IsNullOrWhiteSpace(term)) {
                    // Default view: All approved bookings
                    bookings = await _db.GetBookingsByStatus("Approved");
                } else {
                    // Filtered view: Search within approved bookings
                    bookings = await _db.SearchBookingsAsync(term, "Approved");
                }

                bookingListPanel.Controls.Clear();
                LoadBookingCards(bookings);
            } catch (Exception ex) {
                MessageBox.Show(ex.Message, "Search Error");
            } finally {
                bookingListPanel.BringToFront();
                _loader.HideLoading();
            }
        }
        #endregion

        private void LoadBookingCards(List<BookingDto> bookings) {
            bookingListPanel.Padding = new Padding(0);

            foreach (var booking in bookings) {
                var card = new ucBookingCard();
                card.BindData(booking);
                card.Margin = new Padding(4);
                card.ChangeBtnViewText("Release"); // Customizing the card for Outbound context
                bookingListPanel.Controls.Add(card);
            }

            LayoutFlowLayoutPanel();
        }

        private void LayoutFlowLayoutPanel() {
            const int BOTTOM_PADDING = 10;

            if (bookingListPanel.Controls.Count > 0) {
                var firstCard = bookingListPanel.Controls[0];
                int cardWidthWithMargin = firstCard.Width + firstCard.Margin.Left + firstCard.Margin.Right;
                int cardHeightWithMargin = firstCard.Height + firstCard.Margin.Top + firstCard.Margin.Bottom;

                int itemsPerRow = bookingListPanel.ClientSize.Width / cardWidthWithMargin;
                if (itemsPerRow <= 0) itemsPerRow = 1;

                int totalRows = (int)Math.Ceiling((double)bookingListPanel.Controls.Count / itemsPerRow);
                int flowLayoutHeight = totalRows * cardHeightWithMargin;

                bookingListPanel.Height = flowLayoutHeight + bookingListPanel.Padding.Top + BOTTOM_PADDING;
            }
        }

        // Boilerplate for smooth UI rendering
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Turn on WS_EX_COMPOSITED
                return cp;
            }
        }
    }
}