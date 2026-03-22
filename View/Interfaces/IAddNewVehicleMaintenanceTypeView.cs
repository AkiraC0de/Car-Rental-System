using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.View.Interfaces {
    public interface IAddNewVehicleMaintenanceTypeView {  
        string TaskName { get; }
        string Description { get; }

        int? SuggestedMileageInterval { get; } 
        int? SuggestedMonthInterval { get; }

        void ShowSuccess(string message);
        void ShowError(string message);
        void CloseModal();
    }
}
