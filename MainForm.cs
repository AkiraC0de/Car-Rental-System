using FontAwesome.Sharp;
using System;
using System.Drawing;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using VehicleManagementSystem.Forms;
using VehicleManagementSystem.Classes;
using Guna.UI2.WinForms;

namespace VehicleManagementSystem {

    public partial class MainForm : Form {

        // Fields
        public static MainForm Instance { get; private set; }
        private Form ActiveForm;
        private Label labelComponent;

        private WindowControls WindowActions;
        private MenuRenderer MenuHandler;

        private void InitializeWindow() {
            //ActivateButton(vehManagementBtn, UIConfig.Titles.VehManagement);

            // Helpers
            WindowActions = new WindowControls(this);
            MenuHandler = new MenuRenderer(panelMenu);

            LoadDefaultView();
        }

        private void LoadDefaultView() {
            WindowActions.ToggleMaximize(maximizeBtn);
            OpenForm(new VehManagement());
            MenuHandler.ActivateButton(vehManagementBtn);
        }

        public MainForm() {
            Instance = this;
            InitializeComponent();
            InitializeWindow();
        }

        public void OpenForm(Form childForm) {
            if (ActiveForm != null) {
                ActiveForm.Close();
            }
            panelDesktop.Controls.Clear();
            ActiveForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            panelDesktop.Controls.Add(childForm);
            panelDesktop.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();   
        }

        public void AddHeaderLabel(string label) {
            labelComponent = new Label();

            labelComponent.Tag = label;
            labelComponent.Size = new System.Drawing.Size(207, 200);
            labelComponent.ForeColor = UIConfig.Theme.Primary;
            labelComponent.BackColor = System.Drawing.Color.Transparent;
            labelComponent.Font = new Font("Arial", 10F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            labelComponent.Location = new Point(labelPage.Location.X + labelPage.Width, labelPage.Location.Y);
            labelComponent.Text = " > " + label;

            panelHeader.Controls.Add(labelComponent);

            labelComponent.Visible = true;
            labelComponent.BringToFront();
        }

        private void RemoveHeaderLabel() {
            if (labelComponent != null) {
                panelHeader.Controls.Remove(labelComponent);
            }
        }

        // Windows Actions
        private void CloseButton_Click(object sender, EventArgs e) => WindowActions.Close();
        private async void maximizeBtn_Click(object sender, EventArgs e) => await WindowActions.ToggleMaximize(maximizeBtn);
        private void minimizeBtn_Click(object sender, EventArgs e) => WindowActions.Minimize();
        private void panelHeader_MouseDown(object sender, MouseEventArgs e) => WindowActions.Drag(e);

        // Navigation Functions
        private void vehManagementBtn_Click(object sender, EventArgs e) {
            MenuHandler.ActivateButton(sender);
            labelPage.Text = UIConfig.Titles.VehManagement;
            OpenForm(new VehManagement());
        }

        private void maintenanceMangementBtn_Click(object sender, EventArgs e) {
            MenuHandler.ActivateButton(sender);
            labelPage.Text = UIConfig.Titles.MaintenanceManagement;
            OpenForm(new MaintenanceManagement());
        }
    }
}
