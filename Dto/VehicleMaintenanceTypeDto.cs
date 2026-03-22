using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto {
    public class VehicleMaintenanceTypeDto {
        public int TaskID { get; set; }
        public string TaskName { get; set; }
        public string Description { get; set; }

        public int? SuggestedMileageInterval { get; set; }
        public int? SuggestedMonthInterval { get; set; }

        public override string ToString() {
            return TaskName;
        }
    }
}
