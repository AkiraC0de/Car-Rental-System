using System;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    public partial class frmVehicleManagement : Form {
        public frmVehicleManagement() {
            InitializeComponent();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            NavigationHelper.OpenForm(new frmAddNewVehicle());
            frmMain.Instance.AddHeaderLabel(AppConfig.SubTitles.AddNewVehicle);
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

 
    }
}
