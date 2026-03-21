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
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.View.Modals;

namespace VehicleManagementSystem.UserControls {
    public partial class VehicleDocumentCardControl : UserControl {
        VehicleDocumentDto _document;

        public VehicleDocumentCardControl() {
            InitializeComponent();
        }

        public void Bind(VehicleDocumentDto document) {
            _document = document;
            IntializeData();
        }

        private void IntializeData() {
            labelType.Text = _document.Category;
            labelTitle.Text = _document.Title;
            labelExpirationDate.Text = _document.ExpirationDate?.ToString("d") ?? "N/A";

            if(_document.Category != "Required Renewal") {
                btnRenew.Visible = false;
            }
        }

        private void viewBtn_Click(object sender, EventArgs e) {
            string fullFilePath = Path.Combine(AppConfig.AppData.RootPath, _document.FilePath);

            switch (_document.Extension) {
                case ".docx":
                case ".doc":
                case ".pdf":
                    if (!string.IsNullOrEmpty(fullFilePath)) {
                        System.Diagnostics.Process.Start(new System.Diagnostics.ProcessStartInfo(fullFilePath) { UseShellExecute = true });
                    }
                    break;
                case ".jpg":
                case ".png":
                case ".jpeg":
                    var ImagePreviewModal = new ImagePreviewModal(_document.Title, fullFilePath);
                    ImagePreviewModal.ShowDialog();
                    break;
            }
        }


    }
}
