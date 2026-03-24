using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Classes;
using VehicleManagementSystem.Data.Enums;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Services.Implementations;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Presenters {
    internal class addNewVehicleDocumentPresenter {
        IAddNewVehicleDocumentView _view;
        VehicleDocumentServices _vehicleDocumentServices;

        public addNewVehicleDocumentPresenter(IAddNewVehicleDocumentView view, VehicleDocumentServices vehicleDocumentServices) {
            _view = view;
            _vehicleDocumentServices = vehicleDocumentServices;
        }

        public async void SaveDocument() {
            if (!IsAllInputsValid(_view)) return;

            try {
                string originalPath = _view.DocumentPath;
                string extension = Path.GetExtension(originalPath).ToLower();
                string finalPath = "";

                if (extension == ".docx" || extension == ".doc") {
                    finalPath = ConvertAndSaveDocx(originalPath, _view.VehiclePlateNum);
                    extension = ".pdf";
                } else {
                    finalPath = GetFinalVehicDocumentPath(originalPath, _view.VehiclePlateNum);
                }

                VehicleDocumentDto newDocument = new VehicleDocumentDto {
                    Title = Classes.Helpers.ConvertToCapitalized(_view.DocumentTitle),
                    Category = _view.DocumentType,
                    IssuingAuthority = Classes.Helpers.ConvertToCapitalized(_view.DocumentIssuingAuthority),
                    IssueDate = DateTime.Parse(_view.DocumentIssueDate),
                    VehiclePlateNum = _view.VehiclePlateNum,
                    ExpirationDate = string.IsNullOrEmpty(_view.DocumentExpirationDate)
                                     ? (DateTime?)null : DateTime.Parse(_view.DocumentExpirationDate),
                    FilePath = finalPath,
                    Extension = extension 
                };

                await _vehicleDocumentServices.AddVehicleDocument(newDocument);
                //_view.ShowSuccess(newDocument.FilePath);
                _view.CloseModal();
            } catch (Exception ex) {
                _view.ShowError($"Failed to save document: {ex.Message}");
            }
        }

        private string GetFinalVehicDocumentPath(string originalPath, string plateNum) {
            string subFolderImagePath = Path.Combine(AppConfig.AppData.VehicleImagePath, plateNum);

            string extension = Path.GetExtension(originalPath);
            string cleanTitle = _view.DocumentTitle.Replace(" ", "_");
            string fileName = $"{_view.DocumentType}-{cleanTitle}-{Guid.NewGuid()}{extension}";

            return VehicleManagementSystem.Classes.Helpers.SaveDocumentToAppData(originalPath, subFolderImagePath, fileName);
        }

        private string ConvertAndSaveDocx(string originalPath, string plateNum) {
            string relativeFolder = Path.Combine(
                AppConfig.AppData.DocumentsPath,
                AppConfig.AppData.VehicleImagePath,
                plateNum
            );

            string physicalFolder = Path.Combine(AppConfig.AppData.RootPath, relativeFolder);

            if (!Directory.Exists(physicalFolder)) Directory.CreateDirectory(physicalFolder);

            string cleanTitle = _view.DocumentTitle.Replace(" ", "_");
            string fileName = $"{_view.DocumentType}-{cleanTitle}-{Guid.NewGuid()}.pdf";

            string fullPhysicalPath = Path.Combine(physicalFolder, fileName);

            using (Spire.Doc.Document document = new Spire.Doc.Document()) {
                document.LoadFromFile(originalPath);
                document.SaveToFile(fullPhysicalPath, Spire.Doc.FileFormat.PDF);
                document.Close();
            }

            return Path.Combine(relativeFolder, fileName);
        }

        private bool IsAllInputsValid(IAddNewVehicleDocumentView inputs) {
            bool hadNoError = true;

            if (string.IsNullOrWhiteSpace(inputs.DocumentTitle)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.DocumentPath)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrWhiteSpace(inputs.DocumentIssuingAuthority)) {
                //_view.SetFieldError(AddNewVehicleInputEnums.VehicleIdentificationNumber, "Required.");
                hadNoError = false;
            }

            if (string.IsNullOrEmpty(inputs.DocumentType)) {
                hadNoError = false;
            }

            return hadNoError;
        }
    }
}
