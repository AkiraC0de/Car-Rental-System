using System;
using System.Collections.Generic;
using System.Drawing;
using System.IO;

namespace VehicleManagementSystem.Classes {
    public static class Helpers {

        public static Color GetStatusColor(string status) {
            switch (status.ToLower()) {
                case "rented":
                case "reserved":
                    return Color.DeepSkyBlue;
                case "inmaintenance":
                    return Color.DarkOrange;
                case "outofservice":
                    return Color.Red;
                default:
                    return Color.Green;
            }
        }

        public static Image GetVehicleImage(string ImagePath) {
            string fullImagePath = Path.Combine(
                AppConfig.AppData.RootPath,
                ImagePath
            );

            if (File.Exists(fullImagePath)) {
                return Image.FromFile(fullImagePath);
            }

            return global::VehicleManagementSystem.Properties.Resources.default_car_model;
        }

        static public string SaveImageToAppData(string sourceImagePath, string subFolder) {
            string targetPath = Path.Combine(
                AppConfig.AppData.RootPath, 
                AppConfig.AppData.ImagesPath, 
                subFolder
            );

            Directory.CreateDirectory(targetPath);

            string fileName = Guid.NewGuid().ToString() + Path.GetExtension(sourceImagePath);
            string destinationPath = Path.Combine(targetPath, fileName);

            File.Copy(sourceImagePath, destinationPath, true);

            return Path.Combine(AppConfig.AppData.ImagesPath, subFolder, fileName);
        }

        static public string ConvertToCapitalized(string value) {
            if(string.IsNullOrEmpty(value)) return value;

            string _value = value.Trim();

            return char.ToUpper(_value[0]) + _value.Substring(1);
        }

    }
}
