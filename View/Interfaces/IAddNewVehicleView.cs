using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IAddNewVehicleView {

        int VehicleIdentificationNumber { get; }
        string VehiclePlateNum { get; }
        string VehicleModel { get; }
        int VehicleYearModel { get; }
        string VehicleManufacturer { get; } 
        Bitmap VehicleImage { get; }
    }
}
