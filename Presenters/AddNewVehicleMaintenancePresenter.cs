using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.UserControls;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class AddNewVehicleMaintenancePresenter {
        IAddNewVehicleMaintenanceView _view;
        VehicleMaintenanceServices _service;

        public AddNewVehicleMaintenancePresenter(IAddNewVehicleMaintenanceView view, VehicleMaintenanceServices service) {
            _view = view;
            _service = service;
        }

        public void LoadMaintenanceTypes() {
            var maintenanceTypes = _service.GetAllTaskDefinitions();
            _view.LoadMaintenanceTypes(maintenanceTypes);
        }

        public void LoadMaintenancePreviewCard() {
           
        }



    }
}
