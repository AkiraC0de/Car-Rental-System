using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace VehicleManagementSystem.View.Modals {
    public partial class ImagePreviewModal : Form {

        private WindowControls WindowActions;

        public ImagePreviewModal(string imageName, string imagePath) {
            InitializeComponent();

            WindowActions = new WindowControls(this);

            pictureBox.Image = Image.FromFile(imagePath);
            labelHeader.Text = imageName;
        }

        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void maximizeBtn_Click(object sender, EventArgs e) {
            WindowActions.ToggleMaximize(maximizeBtn);
        }
    }
}
