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
    public partial class frmInbound : Form {
        private ucLoadingOverlay _loader;
        private BookingServices _db;

        // --- Search Debounce ---
        private Timer searchDebounceTimer;

        public frmInbound() {
            InitializeComponent();
            InitializeFirstLoad();
            SetupSearchTimer();
        }

        private void SetupSearchTimer() {
            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350;
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
        }

        private void InitializeFirstLoad() {
            _db = new BookingServices();
            _loader = new ucLoadingOverlay();

            // Ensure layout refreshes on window resize
            this.Resize += (s, e) => LayoutFlowLayoutPanel();

            // Initial load of ongoing rentals
            _ = RefreshInboundList();
        }

        #region Search Logic

        // Link this to your Guna2TextBox.TextChanged event
        private void txtSearch_TextChanged(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private async void SearchDebounceTimer_Tick(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            await RefreshInboundList();
        }

        private async Task RefreshInboundList() {
            string term = searchBox.Text.Trim();

            _loader.ShowLoading(panelLoading);
            panelLoading.BringToFront();

            try {
                List<BookingDto> bookings;

                if (string.IsNullOrWhiteSpace(term)) {
                    // Fetch all active rentals currently out
                    bookings = await _db.GetBookingsByStatus("Ongoing");
                } else {
                    // Search specifically within ongoing rentals
                    bookings = await _db.SearchBookingsAsync(term, "Ongoing");
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
                card.ChangeBtnViewText("Finalize"); // Context for Inbound
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

        // Reduces flickering when loading many controls
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }
    }
}