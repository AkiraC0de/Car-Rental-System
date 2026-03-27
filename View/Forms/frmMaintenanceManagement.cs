using Guna.UI2.WinForms;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Documents;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Services;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.UserControls.MaintenanceTab;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.Forms {
    public partial class frmMaintenanceManagement : Form {
        private Guna2Button ActiveButton;
        private UserControl ActiveUserControl;
        private Guna2Panel LowerPanel;
        private ucLoadingOverlay _loader;

        public frmMaintenanceManagement() {
            InitializeComponent();
            InitializeFirstLoad();
        }

        private void InitializeFirstLoad() {
            hr.FillColor = AppConfig.Theme.Primary;
            _loader = new ucLoadingOverlay();
            ActiveButton = dashboardBtn;
            RenderActiveButton();
            OpenSubPanel(new MaintenanceDashboard(), dashboardBtn);
        }

        public void OpenSubPanel(UserControl control, Guna2Button button) {
            if (ActiveUserControl?.GetType() == control.GetType()) return;

            RemoveActiveButtonStyle();
            ActiveButton = button;

            ActiveUserControl = control;

            panelSubMain.Controls.Clear();

            panelSubMain.Height = ActiveUserControl.Height;
            panelSubMain.Controls.Clear();
            ActiveUserControl.Dock = DockStyle.Fill;

            panelSubMain.AutoScroll = true;
            panelSubMain.Controls.Add(ActiveUserControl);

            RenderActiveButton();
        }

        private void RemoveActiveButtonStyle() {
            ActiveButton.ForeColor = Color.FromArgb(64, 64, 64);
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

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void btnAddType_Click(object sender, EventArgs e) {
            using (var AddNewVehicleMaintenanceTypeModal = new AddNewVehicleMaintenanceTypeModal()) {
                AddNewVehicleMaintenanceTypeModal.ShowDialog();
            }
        }

        private void dashboardBtn_Click(object sender, EventArgs e) {
            OpenSubPanel(new MaintenanceDashboard(), dashboardBtn);
        }
    }
}
