using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleDocumentModal : Form {
        public AddNewVehicleDocumentModal(string PlateNumber) {
            InitializeComponent();

            labelHeader.Text = PlateNumber + ": adding new document";
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }
    }
}
