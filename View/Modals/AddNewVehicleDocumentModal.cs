using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Data.Enums;

namespace VehicleManagementSystem.View.Modals {
    public partial class AddNewVehicleDocumentModal : Form {
        string documentType;
        string documentTitle => inputDocumentTitle.Text;
        string _tempSelectedImagePath;

        public AddNewVehicleDocumentModal(string PlateNumber) {
            InitializeComponent();

            labelHeader.Text = "Adding new document to " + PlateNumber;
        }

   

        // Should have a notice before closing the modal if there was change/s in the input fields
        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void cancelBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void Radio_CheckedChanged(object sender, EventArgs e) {
            var selectedRadio = this.Controls.OfType<System.Windows.Forms.RadioButton>()
                                       .FirstOrDefault(r => r.Checked);

            documentType = selectedRadio.Text;

            if(documentType != "Permanent") {
                ToggleExpirationDateVisibility(true);
            } else {
                ToggleExpirationDateVisibility(false);
            }
        }

        private void ToggleExpirationDateVisibility(bool isVisible) {
            inputExpirationDate.Visible = isVisible;
            labelExpirationDate.Visible = isVisible;
        }

        private void addImageBtn_Click(object sender, EventArgs e) {
            using (OpenFileDialog openFileDialog = new OpenFileDialog()) {
                openFileDialog.Title = "Select an image";
                openFileDialog.Filter = "All Supported Files|*.jpg;*.jpeg;*.png;*.pdf;*.doc;*.docx|" +
                        "Image Files|*.jpg;*.jpeg;*.png|" +
                        "PDF Documents|*.pdf|" +
                        "Word Documents|*.doc;*.docx";
                openFileDialog.Multiselect = false;

                if (openFileDialog.ShowDialog() != DialogResult.OK) return;

                if (documentPictureBox.Image != null) {
                    documentPictureBox.Image.Dispose();
                }

                string fullPath = openFileDialog.FileName;
                string fileNameOnly = Path.GetFileName(fullPath);
                string extension = Path.GetExtension(fullPath).ToLower();

                switch (extension) {
                    case ".docx":
                    case ".doc":
                    case ".pdf":
                        long bytes = new System.IO.FileInfo(fullPath).Length;
                        double mb = (double)bytes / (1024 * 1024);
                        labelFileName.Text = $"{fileNameOnly} ({mb:F2} MB)";

                        panelFile.BringToFront();
                        panelFile.Visible = true;

                        break;
                    case ".jpg":
                    case ".png":
                    case ".jpeg":
                        documentPictureBox.Image = System.Drawing.Image.FromFile(fullPath);
                        documentPictureBox.BringToFront();
                        documentPictureBox.Visible = true;
                        break;
                }

                _tempSelectedImagePath = fullPath;
                closeImageBtn.BringToFront();
                closeImageBtn.Visible = true;
            }
        }

        private void AddNewVehicleDocumentModal_Load(object sender, EventArgs e) {
            inputDocumentTitle.Focus();
            inputExpirationDate.MinDate = DateTime.Today;
            inputExpirationDate.Value = DateTime.Today.AddYears(1);

            inputIssueDate.MaxDate = DateTime.Today;
            inputIssueDate.Value = DateTime.Today;
        }

        private void btnViewAttached_Click(object sender, EventArgs e) {
            if (!string.IsNullOrEmpty(_tempSelectedImagePath))
            {
                System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(_tempSelectedImagePath) { UseShellExecute = true });
            }
        }

        private void closeImageBtn_Click(object sender, EventArgs e) {
            if (documentPictureBox.Image != null) {
                documentPictureBox.Image.Dispose();
            }
            panelFile.Visible = false;
            documentPictureBox.Visible = false;

            //if (_tempSelectedImagePath != null) {
            //    _tempSelectedImagePath = null;
            //}

            closeImageBtn.Visible = false;
            addImageBtn.Visible = true;
        }
    }
}
