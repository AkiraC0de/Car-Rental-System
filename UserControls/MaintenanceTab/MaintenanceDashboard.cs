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

namespace VehicleManagementSystem.UserControls.MaintenanceTab {
    public partial class MaintenanceDashboard : UserControl {
        VehicleMaintenanceServices _services;

        public MaintenanceDashboard() {
            InitializeComponent();
            InitializeFirstLoad();
        }

        private async void InitializeFirstLoad() {
            _services = new VehicleMaintenanceServices();
            var schedules = await _services.GetAllMaintenanceSchedules();
            DisplayDashboard(schedules);
        }

        public void DisplayDashboard(List<VehicleMaintenanceScheduleDto> schedules) {
            int total = schedules.Count;
            int upcoming = schedules.Count(s => s.IsUpcoming);
            int dueSoon = schedules.Count(s => s.IsDueSoon);
            int overdue = schedules.Count(s => s.IsOverdue);

            labelTotalCount.Text = total.ToString();
            labelUpcomingCount.Text = upcoming.ToString();
            labelDueSoonCount.Text = dueSoon.ToString();
            labelOverDueCount.Text = overdue.ToString();

            DisplayMostUpcoming(schedules);
        }

        private void DisplayMostUpcoming(List<VehicleMaintenanceScheduleDto> schedules) {
            var mostUrgent = schedules
                .Where(s => s.Status == "Scheduled" && !s.IsOverdue)
                .OrderByDescending(s => s.MaintenanceProgressPercentage)
                .FirstOrDefault();

            if (mostUrgent == null) return;

            labelMostUpcomingName.Text = $"{mostUrgent.VehiclePlateNum} - {mostUrgent.MaintenanceName}";
            string dayUntil = mostUrgent.DaysUntilDue > 0
                ? $"{mostUrgent.DaysUntilDue} days remaining"
                : $"{Math.Abs(mostUrgent.DaysUntilDue ?? 0)} days have passed";

            labelMostUpcomingDetials.Text = mostUrgent.MilesUntilDue < mostUrgent.DaysUntilDue * 50
                ? $"{mostUrgent.MilesUntilDue:N0} km remaining"
                : dayUntil;
        }
    }
}
