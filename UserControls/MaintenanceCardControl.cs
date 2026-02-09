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

namespace VehicleManagementSystem.UserControls {
    public partial class MaintenanceCardControl : UserControl {
        public MaintenanceCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            if (maintenanceSchedule == null) {
                return;
            }

            labelMaintenanceType.Text = maintenanceSchedule.MaintenanceType;
            labelMaintenanceType.ForeColor = GetStatusColor(maintenanceSchedule.Status);
            labelInterval.Text = GetInterval(maintenanceSchedule);
            labelStatus.Text = maintenanceSchedule.Status;
            labelStatus.ForeColor = GetStatusColor(maintenanceSchedule.Status);

            progressCIrcle.ProgressColor = GetStatusColor(maintenanceSchedule.Status);
            progressCIrcle.ProgressColor2 = GetStatusColor(maintenanceSchedule.Status);
            
            labelDueDate.Text = maintenanceSchedule.NextDueDate?
                                .ToString("MMM dd, yyyy")
                                ?? "—";
            labelDueOdometer.Text = maintenanceSchedule.NextDueOdometer != null ?
                                maintenanceSchedule.NextDueOdometer.ToString() + " km" :
                                "—";
        }

        private double GetOdometerIntervalPercentage( int startKm,int intervalKm, int currentKm) {
                    if (intervalKm <= 0)
                        return 0;

                    // Clamp currentKm within range
                    if (currentKm <= startKm)
                        return 0;

                    if (currentKm >= startKm + intervalKm)
                        return 100;

                    double progress = (double)(currentKm - startKm) / intervalKm * 100;
                    return Math.Round(progress, 2);
        }

        private Color GetStatusColor(string status) {
            if (status == "Upcoming") {
                return Color.SteelBlue; 
            } else if (status == "Due Soon") {
                return Color.Goldenrod; 
            } else if (status == "Overdue") {
                return Color.IndianRed; 
            } else if (status == "Completed") {
                return Color.SeaGreen; 
            } else {
                return Color.Gray; 
            }
        }

        private string GetInterval(VehicleMaintenanceScheduleDto maintenanceSchedule) {
            var parts = new List<string>();

            if (maintenanceSchedule.IntervalKm.HasValue)
                parts.Add($"{maintenanceSchedule.IntervalKm.Value:N0} km");

            if (maintenanceSchedule.IntervalMonths.HasValue)
                parts.Add($"{maintenanceSchedule.IntervalMonths.Value} months");

            if (parts.Count == 0)
                return "—";

            return "Every " + string.Join(" or ", parts);
        }

    }
}
