using System;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    public partial class VehManagement : Form {
        public VehManagement() {
            InitializeComponent();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            MainForm.Instance.OpenForm(new AddNewVeh());
            MainForm.Instance.AddHeaderLabel(UIConfig.SubTitles.AddNewVehicle);
        }
    }
}
