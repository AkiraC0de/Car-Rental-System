using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto {
    public class VehicleMaintenanceScheduleDto {
        public Guid Id { get; set; }

        public string PlateNumber { get; set; }

        public string MaintenanceType { get; set; }       
        public string Description { get; set; }

        public int? IntervalKm { get; set; }         
        public int? IntervalMonths { get; set; }    

        public DateTime? LastPerformedDate { get; set; }
        public int? LastPerformedOdometer { get; set; }

        public DateTime? NextDueDate { get; set; }
        public int? NextDueOdometer { get; set; }

        public string Status { get; set; }
        public string Priority { get; set; }         
    }
}
