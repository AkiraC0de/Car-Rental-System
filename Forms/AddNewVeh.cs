using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;

namespace VehicleManagementSystem.Forms {
    public partial class AddNewVeh : Form {
        public AddNewVeh() {
            InitializeComponent();

            AppConfig.SetDoubleBuffer(tableBasicInfo, true);
            AppConfig.SetDoubleBuffer(panelBasicInfoLeft, true);
            AppConfig.SetDoubleBuffer(panelBasicInfoRight, true);

        }

       
    }
}
