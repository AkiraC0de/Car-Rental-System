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
        private WindowControls WindowActions;
        private IconButton currentActiveButton;
        private Guna2GradientPanel leftBorderButton;
        private Form ActiveForm;
        private Label labelComponent;

        private void InitializeWindow() {
            ActivateButton(vehManagementBtn, UIConfig.Titles.VehManagement);
            WindowActions = new WindowControls(this);
            OpenForm(new VehManagement());
            WindowActions.ToggleMaximize(maximizeBtn);
        }

        private void InitializedButtonLeftBorder() {
            leftBorderButton = new Guna2GradientPanel();
            leftBorderButton.Size = new Size(10, 85);

            leftBorderButton.BorderRadius = 10;
            leftBorderButton.CustomizableEdges.TopLeft = false;
            leftBorderButton.CustomizableEdges.BottomLeft = false;
            leftBorderButton.FillColor = UIConfig.Theme.Primary;
            leftBorderButton.FillColor2 = UIConfig.Theme.Primary;
            leftBorderButton.GradientMode = System.Drawing.Drawing2D.LinearGradientMode.BackwardDiagonal;
            leftBorderButton.TabIndex = 0;

            leftBorderButton.BackColor = Color.Transparent;

            panelMenu.Controls.Add(leftBorderButton);
        }

        public MainForm() {
            Instance = this;
            InitializeComponent();
            InitializedButtonLeftBorder();
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
            labelComponent.Location = new Point(pageLabel.Location.X + pageLabel.Width, pageLabel.Location.Y);
            labelComponent.Text = " > " + label;

            panelHeader.Controls.Add(labelComponent);

            labelComponent.Visible = true;
            labelComponent.BringToFront();
        }

        private void ActivateButton(object senderBtn, string PageTitle) {
            if (senderBtn != null) {
                DeactiveButton();

                pageLabel.Text = PageTitle;
                currentActiveButton = senderBtn as IconButton;
                currentActiveButton.IconSize = 60;
                currentActiveButton.ForeColor = UIConfig.Theme.Primary;
                currentActiveButton.IconColor = UIConfig.Theme.Primary;

                leftBorderButton.Location = new Point(0, currentActiveButton.Location.Y);
                leftBorderButton.Visible = true;
                leftBorderButton.BringToFront();
            }
        }

        private void DeactiveButton() {
            if (currentActiveButton != null) {
                RemoveHeaderLabel();
                currentActiveButton.IconSize = 50;
                currentActiveButton.ForeColor = UIConfig.Theme.SecondaryText;
                currentActiveButton.IconColor = UIConfig.Theme.SecondaryText;
            }
        }
        private void RemoveHeaderLabel() {
            if (labelComponent != null) {
                panelHeader.Controls.Remove(labelComponent);
            }
        }

        private void CloseButton_Click(object sender, EventArgs e) {
            WindowActions.Close();
        }

        // Maximize the Form
        private async void maximizeBtn_Click(object sender, EventArgs e) {
            await WindowActions.ToggleMaximize(maximizeBtn);
        }

        // Minimize Form
        private void minimizeBtn_Click(object sender, EventArgs e) {
            WindowActions.Minimize();
        }

        // Activate the Drag Ability for Header
        private void panelHeader_MouseDown(object sender, MouseEventArgs e) {
            WindowActions.Drag(e);
        }

        private void vehManagementBtn_Click(object sender, EventArgs e) {
            ActivateButton(sender, UIConfig.Titles.VehManagement);
            OpenForm(new VehManagement());
        }

        private void maintenanceMangementBtn_Click(object sender, EventArgs e) {
            ActivateButton(sender, UIConfig.Titles.MaintenanceManagement);
            OpenForm(new MaintenanceManagement());
        }
    }
}
