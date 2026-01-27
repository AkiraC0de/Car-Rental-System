using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;
using VehicleManagementSystem.Data.Enums;

namespace VehicleManagementSystem.Presentor {
    public class addNewVehiclePresenter {
        IAddNewVehicleView _view;
        VehicleServices _vehicleServices;

        public addNewVehiclePresenter(IAddNewVehicleView view, VehicleServices vehicleServices) {
            _view = view;
            _vehicleServices = vehicleServices;
        }


        public void SaveVehicle() {
            ValidateInputs(_view);
        }

        private void ValidateInputs(IAddNewVehicleView inputs) {
            if (string.IsNullOrWhiteSpace(inputs.VehicleIdentificationNumber)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "");
            }

            if (string.IsNullOrWhiteSpace(inputs.VehiclePlateNum)) {
                _view.SetFieldError(AddNewVehicleInputEnums.VehiclePlateNum, "");
            }
        }

    } 
}
