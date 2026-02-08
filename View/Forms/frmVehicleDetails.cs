using Guna.UI2.WinForms;
using System.Collections.Generic;
using System.Drawing;
using System.Management.Instrumentation;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.UserControls;

namespace VehicleManagementSystem.View.Forms {
    public partial class frmVehicleDetails : Form {
        public static frmVehicleDetails Instance;
        private VehicleDto _vehicle;
        private Guna2Button ActiveButton;
        private UserControl ActiveUserControl;
        private Guna2Panel LowerPanel;

        public frmVehicleDetails(VehicleDto vehicle) {
            Instance = this;
            _vehicle = vehicle;

            InitializeComponent();
            LoadUI();

            ActiveButton = overviewBtn;
            OpenSubPanel(new VehicleDetailsOverview(_vehicle));
        }

        public void OpenSubPanel(UserControl control) { 
            ActiveUserControl = control;

            panelSubMain.Controls.Clear();
            panelSubMain.SuspendLayout();

            panelSubMain.Height = ActiveUserControl.Height;
            panelSubMain.Controls.Clear();
            ActiveUserControl.Dock = DockStyle.Fill;

            panelSubMain.AutoScroll = true;
            panelSubMain.Controls.Add(ActiveUserControl);
            
            panelSubMain.ResumeLayout(true);
            RenderActiveButton();
        }

        private void maintenanceBtn_Click(object sender, System.EventArgs e) {
            RemoveActiveButtonStyle();
            ActiveButton = maintenanceBtn;
            OpenSubPanel(new VehicleCardControl());
        }

        private void overviewBtn_Click(object sender, System.EventArgs e) {
            RemoveActiveButtonStyle();
            ActiveButton = overviewBtn;
            OpenSubPanel(new VehicleDetailsOverview(_vehicle));
        }

        private void documentsBtn_Click(object sender, System.EventArgs e) {
            RemoveActiveButtonStyle();
            ActiveButton = documentsBtn;
            OpenSubPanel(new VehicleDetailsDocuments(_vehicle));
        }

        private void RenderActiveButton() {
            panelNav.Controls.Remove(LowerPanel);

            LowerPanel = new Guna2Panel() {
                BackColor = Color.Transparent,
                Width = ActiveButton.Width,
                Height = 10,
                FillColor = AppConfig.Theme.Primary,
                Location = new Point(ActiveButton.Location.X, 76 - 9),
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

        private void LoadUI() {
            hr.FillColor = AppConfig.Theme.Primary;
            labelSubHeader.Text = GetVehicleSubHeader(_vehicle);
            //labelStatus.FillColor = Helpers.GetStatusColor(_vehicle.CurrentStatus);
            //labelStatus.Text = _vehicle.CurrentStatus.ToString();
            //labelStatus.Location = new Point(labelSubHeader.Right + 5, labelStatus.Location.Y);
        }

        private string GetVehicleSubHeader(VehicleDto vehicle) {
            return $"{vehicle.Manufacturer} - {vehicle.Model} {vehicle.YearModel}";
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

        private void backBtn_Click(object sender, System.EventArgs e) {
            NavigationHelper.OpenForm(new frmVehicleManagement());
        }

        
    }
}
