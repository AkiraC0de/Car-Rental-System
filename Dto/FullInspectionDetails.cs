using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Dto {
    public class FullInspectionDetailsDto {
        public string GeneralNotes { get; set; }
        public string DamageDescriptions { get; set; } // Combined text for the textbox
        public List<string> ImagePaths { get; set; } = new List<string>();
    }
}
