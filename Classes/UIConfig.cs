using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;

namespace VehicleManagementSystem.Classes {
    public static class UIConfig {
        public static class Theme {
            public static readonly Color Primary = Color.FromArgb(71, 108, 255);
            public static readonly Color PrimaryText = Color.FromArgb(44, 44, 44);
            public static readonly Color SecondaryText = Color.Gray;
        }

        public static class Titles {
            public const string VehManagement = "Vehicle Management";
            public const string MaintenanceManagement = "Maintenance Management";
        }

        public static class SubTitles {
            public const string AddNewVehicle = "Adding new car";
        }
    }
}
