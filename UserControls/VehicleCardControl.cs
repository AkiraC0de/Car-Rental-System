using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleCardControl : UserControl {
        public VehicleCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleDto vehicle) {
            LoadVehicleImage(vehicle.ImagePath);

            labelMainHeader.Text = vehicle.LicensePlate;
            labelSubHader.Text = GetCardSubHeader(vehicle);
            labelDailyRate.Text = GetFormattedDialyRate(vehicle.DailyRate);
            labelCurrentOdometer.Text = vehicle.CurrentOdometerReading.ToString() + " Km";
            pictureBoxTransmission.Image = GetTransmissionIcon(vehicle.Transmission);

            labelStatus.Text = vehicle.CurrentStatus;
            labelStatus.ForeColor = GetStatusColor(vehicle.CurrentStatus);
        }

        private Color GetStatusColor(string status) {
            switch (status.ToLower()) {
                case "rented":
                case "reserved":
                    return Color.DeepSkyBlue;
                    break;
                case "inmaintenance":
                    return Color.Orange;
                    break;
                case "outofservice":
                    return Color.Red;
                    break;
                default:
                    return Color.Green;
                    break;
            }
        }

        private Image GetTransmissionIcon(string transmissionType) {
            if(transmissionType.ToLower() == "automatic")
                return global::VehicleManagementSystem.Properties.Resources.auto_transmission_icon;

            return global::VehicleManagementSystem.Properties.Resources.manual_transmission_icon;
        }

        private string GetCardSubHeader(VehicleDto vehicle) {
            return $"{vehicle.Manufacturer} - {vehicle.Model} {vehicle.YearModel}";
        }

        private string GetFormattedDialyRate(decimal dailyRate) {
            return $"₱{dailyRate}/day";
        }

        private void LoadVehicleImage(string ImagePath) {
            string fullImagePath = Path.Combine(
                AppConfig.AppData.RootPath,
                ImagePath
            );

            if (File.Exists(fullImagePath)) {
                pictureVehicle.Image = Image.FromFile(fullImagePath);
            }
        }
    }
}
