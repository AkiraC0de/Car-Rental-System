using Guna.UI2.WinForms;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmBookings : Form {
        private Guna2Button ActiveButton;
        private ucLoadingOverlay _loader;
        private Guna2Panel LowerPanel;
        private BookingServices _db;

        // --- Search & State Fields ---
        private Timer searchDebounceTimer;
        private string _currentStatus = "Pending";

        public frmBookings() {
            InitializeComponent();
            InitializeFirstLoad();
            SetupSearchTimer();
        }

        private void SetupSearchTimer() {
            searchDebounceTimer = new Timer();
            searchDebounceTimer.Interval = 350;
            searchDebounceTimer.Tick += SearchDebounceTimer_Tick;
        }

        private async void InitializeFirstLoad() {
            hr.FillColor = AppConfig.Theme.Primary;
            this.Resize += (s, e) => LayoutFlowLayoutPanel();
            _db = new BookingServices();
            _loader = new ucLoadingOverlay();

            ActiveButton = pendingBtn;
            await HandleStatusButtonClick(pendingBtn, "Pending");
        }

        #region Search Logic
        // Trigger this from your searchBarTextBox.TextChanged event in the Designer
        private void searchBarTextBox_TextChanged(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            searchDebounceTimer.Start();
        }

        private async void SearchDebounceTimer_Tick(object sender, EventArgs e) {
            searchDebounceTimer.Stop();
            await RefreshActiveList();
        }

        private async Task RefreshActiveList() {
            string term = searchBox.Text.Trim();
            _loader.ShowLoading(panelLoading);
            panelLoading.BringToFront();

            try {
                List<BookingDto> bookings;

                if (string.IsNullOrWhiteSpace(term)) {
                    // Standard fetch based on tab
                    bookings = (_currentStatus == "All")
                        ? await _db.GetAllBookings()
                        : await _db.GetBookingsByStatus(_currentStatus);
                } else {
                    // Search fetch using the current tab's status
                    bookings = await _db.SearchBookingsAsync(term, _currentStatus);
                }

                ClearFlowLayout();
                LoadBookingCards(bookings);
            } catch (Exception ex) {
                MessageBox.Show("Error refreshing list: " + ex.Message);
            } finally {
                flowLayoutPanel1.BringToFront();
                _loader.HideLoading();
            }
        }
        #endregion

        private void LoadBookingCards(List<BookingDto> bookings) {
            flowLayoutPanel1.Padding = new Padding(0);
            foreach (var booking in bookings) {
                var card = new ucBookingCard();
                card.BindData(booking);
                card.Margin = new Padding(4);
                flowLayoutPanel1.Controls.Add(card);
            }
            LayoutFlowLayoutPanel();
        }

        private void LayoutFlowLayoutPanel() {
            const int BOTTOM_PADDING = 10;

            if (flowLayoutPanel1.Controls.Count > 0) {
                var firstCard = flowLayoutPanel1.Controls[0];

                int cardWidthWithMargin = firstCard.Width + firstCard.Margin.Left + firstCard.Margin.Right;
                int cardHeightWithMargin = firstCard.Height + firstCard.Margin.Top + firstCard.Margin.Bottom;

                int itemsPerRow = flowLayoutPanel1.ClientSize.Width / cardWidthWithMargin;
                if (itemsPerRow <= 0) itemsPerRow = 1;

               
                int totalRows = (int)Math.Ceiling((double)flowLayoutPanel1.Controls.Count / itemsPerRow);

                int flowLayoutHeight = totalRows * cardHeightWithMargin;

                flowLayoutPanel1.Height = flowLayoutHeight + flowLayoutPanel1.Padding.Top + BOTTOM_PADDING;
            }
        }

        private void ClearFlowLayout() {
            flowLayoutPanel1.Controls.Clear();
        }

        private void RenderActiveButton() {
            if (LowerPanel != null) {
                panelNav.Controls.Remove(LowerPanel);
            }

            LowerPanel = new Guna2Panel() {
                BackColor = Color.Transparent,
                Width = ActiveButton.Width,
                Height = 10,
                FillColor = AppConfig.Theme.Primary,
                Location = new Point(ActiveButton.Location.X, ActiveButton.Location.Y + ActiveButton.Height - 8),
                BorderRadius = 10,
                Margin = new Padding(0)
            };

            LowerPanel.CustomizableEdges.BottomRight = false;
            LowerPanel.CustomizableEdges.BottomLeft = false;
            panelNav.Controls.Add(LowerPanel);
            LowerPanel.Visible = true;
            LowerPanel.BringToFront();

            ActiveButton.ForeColor = AppConfig.Theme.Primary;
        }

        private void RemoveActiveButtonStyle() {
            ActiveButton.ForeColor = Color.FromArgb(64, 64, 64);
        }

        private async Task HandleStatusButtonClick(Guna2Button button, string status) {
            RemoveActiveButtonStyle();
            ActiveButton = button;
            _currentStatus = status; // Sync the state
            RenderActiveButton();

            // Note: We don't clear the search bar here so the user can 
            // switch tabs while keeping their search filter active.
            await RefreshActiveList();
        }

        #region Navigation Events
        private async void pendingBtn_Click(object sender, EventArgs e) => await HandleStatusButtonClick(pendingBtn, "Pending");
        private async void approvedBtn_Click(object sender, EventArgs e) => await HandleStatusButtonClick(approvedBtn, "Approved");
        private async void rejectedBtn_Click(object sender, EventArgs e) => await HandleStatusButtonClick(rejectedBtn, "Rejected");
        private async void completedBtn_Click(object sender, EventArgs e) => await HandleStatusButtonClick(completedBtn, "Completed");

        private async void allBtn_Click(object sender, EventArgs e) {
            // Using the same handler ensures the "All" status is stored correctly
            await HandleStatusButtonClick(allBtn, "All");
        }
        #endregion

        private void clearSearchbarBtn_Click(object sender, EventArgs e) {
            searchBox.Clear();
        }

        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000; // Double Buffering
                return cp;
            }
        }
    }
}