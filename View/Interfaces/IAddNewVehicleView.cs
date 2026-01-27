

using VehicleManagementSystem.Data.Enums;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IAddNewVehicleView {

        string VehicleIdentificationNumber { get; }
        string VehiclePlateNum { get; }
        string VehicleModel { get; }
        string VehicleYearModel { get; }
        string VehicleManufacturer { get; } 
        string VehicleCatergory { get; }
        string VehicleColor { get; }
        string VehicleImagePath { get; }

        string VehiclePurchaseDate { get; }
        string VehiclePurchasePrice { get; }
        string VehicleCurrentOdometer { get; }

        string VehicleDailyRate { get; }
        string VehicleFuelType { get; }
        string VehicleTransmissionType { get; }
        string VehicleSeatCapacity { get; }

        void ShowError(string message);
        void SetFieldError(AddNewVehicleInputEnums field, string message);
    }
}
