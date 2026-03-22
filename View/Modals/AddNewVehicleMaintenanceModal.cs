using System;
using System.Collections.Generic;
using System.Web.UI.WebControls;
using System.Windows.Forms;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Presenters;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleMaintenanceModal : Form, IAddNewVehicleMaintenanceView {
        AddNewVehicleMaintenancePresenter _presenter;

        public string MaintenanceType => inputType.Text;
        public int SelectedMainId => (inputType.SelectedItem as VehicleMaintenanceTypeDto)?.TaskID ?? 0;
        public int? IntervalKm { get {
                if (int.TryParse(inputMilleageInterval.Text, out int result)) return result;
                return null;
            }
        }

        public int? IntervalMonths { get {
                if (int.TryParse(inputMonthlyInterval.Text, out int result)) return result;
                return null;
            }
        }

        public int StartingMileage {
            get {
                if (decimal.TryParse(inputStartingMileage.Text, out decimal result)) return (int)result;
                return 0;
            }
        }

        public DateTime LastPerformedDate => inputLastServiceDate.Value;

        public int? NextDueOdometer => StartingMileage + IntervalKm;

        public DateTime? NextDueDate => IntervalMonths.HasValue
            ? LastPerformedDate.AddMonths(IntervalMonths.Value)
            : (DateTime?)null;

        public VehicleMaintenanceTypeDto SelectedType {
            get { return inputType.SelectedItem as VehicleMaintenanceTypeDto; }
        }

        VehicleDto _vehicle;

        public AddNewVehicleMaintenanceModal(VehicleDto vehicle) {
            InitializeComponent();
            _vehicle = vehicle;
            _presenter = new AddNewVehicleMaintenancePresenter(this, new Services.Implementations.VehicleMaintenanceServices());

            inputLastServiceDate.Value = DateTime.Today;
            inputLastServiceDate.MaxDate = DateTime.Today;
            labelHeader.Text = "Adding new maintenance schedule to " + _vehicle.LicensePlate;
            inputStartingMileage.Text = _vehicle.CurrentOdometerReading.ToString();
        }

        private void LoadPreviewCard() {
       
            var newMaintenanceSchedule = new VehicleMaintenanceScheduleDto {
                TaskId = SelectedMainId,
                MaintenanceType = MaintenanceType,
                Description = SelectedType?.Description,

                IntervalKm = IntervalKm,
                IntervalMonths =IntervalMonths,

                LastPerformedOdometer = StartingMileage,
                LastPerformedDate = LastPerformedDate,
                NextDueOdometer = NextDueOdometer,
                NextDueDate = NextDueDate,

                PlateNumber = _vehicle.LicensePlate 
            };

            maintenanceCardControl.Bind(newMaintenanceSchedule, _vehicle.CurrentOdometerReading);
        }

        public void LoadMaintenanceTypes(List<VehicleMaintenanceTypeDto> tasks) {
            inputType.DataSource = null; 
            inputType.DataSource = tasks;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void AddNewVehicleMaintenanceModal_Load(object sender, EventArgs e) {
            _presenter.LoadMaintenanceTypes();
            LoadPreviewCard();
        }

        private void PreviewCard_Load(object sender, EventArgs e) {
            LoadPreviewCard();
        }

        private void cmbMaintenanceTask_SelectedIndexChanged(object sender, EventArgs e) {
            if (SelectedType != null) {
                inputMilleageInterval.Text = SelectedType.DefaultMileageInterval?.ToString() ?? "";
                inputMonthlyInterval.Text = SelectedType.DefaultMonthInterval?.ToString() ?? "";
            }

            LoadPreviewCard();
        }
    }
}
