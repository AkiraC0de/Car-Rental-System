using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsDocuments : UserControl {
        private VehicleDto _vehicle;
        public VehicleDetailsDocuments(VehicleDto vehicle) {
            _vehicle = vehicle;
            InitializeComponent();

            tableMain.SuspendLayout();

            var documentCard = new VehicleDocumentCardControl();
            documentCard.Dock = DockStyle.Fill;

            var documentCard1 = new VehicleDocumentCardControl();
            documentCard1.Dock = DockStyle.Fill;

            var documentCard2 = new VehicleDocumentCardControl();
            documentCard2.Dock = DockStyle.Fill;

            tableMain.Controls.Add(documentCard);
            tableMain.Controls.Add(documentCard1);
            

            tableMain.ResumeLayout();

            tableMain.Controls.Add(documentCard2);
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {

        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            var addVehicleForm = new AddNewVehicleDocumentModal(_vehicle.LicensePlate);
            addVehicleForm.ShowDialog();
        }
    }
}
