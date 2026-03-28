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
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class ucMaintenanceDashboard : UserControl {
        VehicleMaintenanceScheduleDto _schedule;
        private Action _reloadDisplay;

        public ucMaintenanceDashboard() {
            InitializeComponent();
        }

        public void Bind(VehicleMaintenanceScheduleDto schedule, Action reloadDisplay) {
            _schedule = schedule;
            _reloadDisplay = reloadDisplay;
            string daysDue = schedule.DaysUntilDue <= 0
                ? $"{Math.Abs(schedule.DaysUntilDue ?? 0)} days ago"
                : $"in {schedule.DaysUntilDue} days";

            string mileigeDue = $"{schedule.MilesUntilDue}km";

            labelPlateNum.Text = schedule.VehiclePlateNum;
            labelMaintenanceType.Text = schedule.MaintenanceName;
            labelDue.Text = schedule.DueDate != null ? daysDue : "N/A";
            labelOver.Text = schedule.DueMileage != null ? mileigeDue : "N/A"; 
            labelScheduleType.Text = schedule.ScheduleType;
        }

        private void Card_Click(object sender, EventArgs e) {
            if (_schedule == null) return;

            using (var viewCardModal = new ViewVehicleMaintenanceModal(_schedule)) {
                DialogResult dialogResult = viewCardModal.ShowDialog();

                if (dialogResult != DialogResult.OK) return;

                if (_reloadDisplay == null) return;

                _reloadDisplay();
            }
        }


    }
}
