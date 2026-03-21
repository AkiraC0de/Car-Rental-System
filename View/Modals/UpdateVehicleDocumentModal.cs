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
using System.Xml.Linq;
using VehicleManagementSystem.Dto;

namespace VehicleManagementSystem.View.Modals {
    public partial class UpdateVehicleDocumentModal : Form {
        public string DocumentType => this.Controls.OfType<RadioButton>()
                                        .FirstOrDefault(r => r.Checked)?.Text ?? "";
        public string DocumentTitle => inputDocumentTitle.Text;
        public string DocumentIssuingAuthority => inputIssuingAuthority.Text;

        public string VehiclePlateNum => _tempPlateNum;

        public string DocumentExpirationDate => inputExpirationDate.Text;
        public string DocumentIssueDate => inputIssueDate.Text;
        public string DocumentPath => _tempSelectedFilePath;

        string _tempSelectedFilePath;
        string _tempPlateNum;

        VehicleDocumentDto _currentDocument;

        public UpdateVehicleDocumentModal(VehicleDocumentDto document) {
            InitializeComponent();
            _currentDocument = document;
        }

        // Should have a notice before closing the modal if there was change/s in the input fields
        private void closeBtn_Click(object sender, EventArgs e) {
            this.Close();
        }

        private void LoadPreviousData() {
            inputDocumentTitle.Text = _currentDocument.Title;
            inputIssueDate.Value = _currentDocument.IssueDate;
            //inputExpirationDate.Value = _currentDocument?.ExpirationDate ?? null ;
        }

        private void Radio_CheckedChanged(object sender, EventArgs e) {
            if (DocumentType != "Permanent") {
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

                _tempSelectedFilePath = fullPath;
                closeImageBtn.BringToFront();
                closeImageBtn.Visible = true;
            }
        }

        private void closeImageBtn_Click(object sender, EventArgs e) {
            if (documentPictureBox.Image != null) {
                documentPictureBox.Image.Dispose();
                documentPictureBox.Image = null;
            }
            panelFile.Visible = false;
            documentPictureBox.Visible = false;

            _tempSelectedFilePath = null;

            closeImageBtn.Visible = false;
            addImageBtn.Visible = true;
            labelFileName.Text = "No file selected";
        }
    }
}
    
