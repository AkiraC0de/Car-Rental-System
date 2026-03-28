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
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls.MaintenanceTab {
    public partial class ucMaintenanceType : UserControl {
        VehicleMaintenanceServices _services;

        public ucMaintenanceType() {
            InitializeComponent();
            _services = new VehicleMaintenanceServices();

            ReloadAll();
        }

        private void addNewVehBtn_Click(object sender, EventArgs e) {
            using (var AddNewVehicleMaintenanceTypeModal = new AddNewVehicleMaintenanceTypeModal()) {
                AddNewVehicleMaintenanceTypeModal.ShowDialog();
            }
        }

        private async void ReloadAll() {
            var types = await _services.GetAllMaintenanceTypes();
            DisplayTypes(types);
        }

        public void DisplayTypes(List<VehicleMaintenanceTypeDto> types) {
            tableLayoutTypes.SuspendLayout();
            const int DocumentCardHeight = 73;
            int TableMainHeight = DocumentCardHeight * types.Count;

            tableLayoutTypes.Controls.Clear();
            tableLayoutTypes.RowStyles.Clear();
            tableLayoutTypes.RowCount = 0;
            tableLayoutTypes.Height = TableMainHeight;
            this.Height += (TableMainHeight);

            int col = 0;
            int row = 0;

            foreach (var type in types) {
                var card = new ucMaintenanceTypeCard();
                card.Bind(type, ReloadAll);
                card.Dock = DockStyle.Fill;

                tableLayoutTypes.Controls.Add(card, col, row);

                row++;
            }

            tableLayoutTypes.ResumeLayout();
        }
    }
}
