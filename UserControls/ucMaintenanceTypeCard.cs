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

namespace VehicleManagementSystem.UserControls {
    public partial class ucMaintenanceTypeCard : UserControl {
        Action _reloadAction;
        VehicleMaintenanceServices _services;
        VehicleMaintenanceTypeDto _type;

        public ucMaintenanceTypeCard() {
            InitializeComponent();
            _services = new VehicleMaintenanceServices(); ;
        }

        public void Bind(VehicleMaintenanceTypeDto type, Action reloadAction) {
            labelPriority.Text = type.Priority;
            labelName.Text = type.MaintenanceName;
            labelDesc.Text = type.Description;

            _reloadAction = reloadAction;
            _type = type;
        }

        private async void btnDelete_Click(object sender, EventArgs e) {
            DialogResult confirm = MessageBox.Show(
                $"Are you sure you want to delete the maintenance type '{_type.MaintenanceName}'? " +
                "This action cannot be undone if the type is not in use.",
                "Confirm Deletion",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning
            );

            if (confirm == DialogResult.Yes) {
                try {
                    var result = await _services.RemoveMaintenanceType(_type.MaintenanceTypeID);

                    if (result.success) {
                        MessageBox.Show(result.message, "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);

                        _reloadAction();
                    } else {
                        MessageBox.Show(result.message, "Deletion Failed", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                } catch (Exception ex) {
                    MessageBox.Show($"An error occurred: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
