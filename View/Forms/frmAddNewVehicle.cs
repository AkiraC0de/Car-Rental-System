using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Forms {
    public partial class frmAddNewVehicle : Form, IAddNewVehicleView {

        public int VehicleIdentificationNumber => int.Parse(inputVehicleIdentificationNumber.Text);
        public string VehiclePlateNum => inputPlateNum.Text;
        public string VehicleModel => inputModel.Text;
        public int VehicleYearModel => int.Parse(inputYearModel.Text);
        public string VehicleManufacturer => inputManufacturer.Text;
        public Bitmap VehicleImage => inputVehicleImage == null
            ? null
            : new Bitmap(inputVehicleImage);


        private Bitmap inputVehicleImage;

        public frmAddNewVehicle() {
            InitializeComponent();
        }

        // Automatically add Double Buffering to the whole form
        // Boilerplate From Stackoverflow
        protected override CreateParams CreateParams {
            get {
                CreateParams cp = base.CreateParams;
                cp.ExStyle |= 0x02000000;
                return cp;
            }
        }

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {


                if (openFileDialog.ShowDialog() == DialogResult.OK) {
                    if (inputVehicleImage != null) {
                        inputVehicleImage.Dispose();
                    }

                    string fullPath = openFileDialog.FileName;
                    string fileNameOnly = System.IO.Path.GetFileName(fullPath);

                    byte[] imageBytes = File.ReadAllBytes(openFileDialog.FileName);
                    using (MemoryStream ms = new MemoryStream(imageBytes)) {
                        inputVehicleImage = new Bitmap(ms);
                    }

                    vehicleImageFilename.Text = fileNameOnly;
                }
            }
        }


    }
}
