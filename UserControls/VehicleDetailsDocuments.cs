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
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDetailsDocuments : UserControl, IVehicleDetailsDocumentView {
        private VehicleDto _vehicle;
        private vehicleDetailsDocumentPresenter _presenter;

        public string VehiclePlateNum => _vehicle.LicensePlate;

        public VehicleDetailsDocuments(VehicleDto vehicle) {
            _vehicle = vehicle;
            InitializeComponent();
            _presenter = new vehicleDetailsDocumentPresenter(this, new Services.Implementations.VehicleDocumentServices());
        }

        public void ShowError(string error) {
            MessageBox.Show(error, "Error");
        }

        public void DisplayDocuments(List<VehicleDocumentDto> documents) {
            tableMain.SuspendLayout();
            const int DocumentCardHeight = 84;

            tableMain.Controls.Clear();
            tableMain.RowStyles.Clear();
            tableMain.RowCount = 0;
            tableMain.Height = DocumentCardHeight * documents.Count;

            int col = 0;
            int row = 0;

            foreach (var document in documents) {
                var card = new VehicleDocumentCardControl();
                card.Bind(document);
                card.Dock = DockStyle.Fill;
                //card.Margin = new Padding(10);

                tableMain.Controls.Add(card, col, row);

                row++;
            }

            tableMain.ResumeLayout();
        }

        private void searchBox_TextChanged(object sender, EventArgs e) {

        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            var addVehicleDocumentForm = new AddNewVehicleDocumentModal(_vehicle.LicensePlate);
            addVehicleDocumentForm.ShowDialog();
        }

        private void VehicleDetailsDocuments_Load(object sender, EventArgs e) {
            _presenter.LoadAllDocuments();
        }
    }
}
