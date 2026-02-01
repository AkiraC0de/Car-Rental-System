
using System;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.Services.Interfaces;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    public class vehicleManagementPresenter {
        IVehicleManagementView _view;
        VehicleServices _vehicleServices;

        public vehicleManagementPresenter(IVehicleManagementView view, VehicleServices vehicleServices) {
            _view = view;
            _vehicleServices = vehicleServices;
        }

        public void LoadAllVehicles() {
            try {
                var vehicles = _vehicleServices.GetAllVehicles();
                _view.DisplayVehicles(vehicles);
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }

        public void LoadSearchedVehicle() {
            if (string.IsNullOrWhiteSpace(_view.SearchQuery)) {
                LoadAllVehicles();
                return;
            }

            try {
                var vehicles = _vehicleServices.GetSearchedVehicle(_view.SearchQuery);
                _view.DisplayVehicles(vehicles);
            } catch (Exception ex) {
                _view.ShowError(ex.Message);
            }
        }
    }
}
