using MySqlConnector;
using System.Collections.Generic;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Dto;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services.Interfaces;

namespace VehicleManagementSystem.Services.Implementations {
    public class VehicleServices : IVehicleService {

        public List<VehicleDto> GetAllVehicles() {
            var vehicles = new List<VehicleDto>();

            using (MySqlConnection conn = MySQLConnectionContext.Create()) {
                conn.Open();

                string sql = "SELECT * FROM Vehicles";

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                using (MySqlDataReader reader = cmd.ExecuteReader()) {
                    while (reader.Read()) {
                        vehicles.Add(new VehicleDto {
                            VIN = reader.GetString("VIN"),
                            LicensePlate = reader.GetString("LicensePlate"),

                            Manufacturer = reader.GetString("Manufacturer"),
                            Model = reader.GetString("Model"),
                            YearModel = reader.GetInt32("YearModel"),
                            Color = reader.GetString("Color"),

                            Category = reader.GetString("Category"),
                            FuelType = reader.GetString("FuelType"),
                            Transmission = reader.GetString("Transmission"),
                            SeatingCapacity = reader.GetInt32("SeatingCapacity"),

                            PurchaseDate = reader.GetDateTime("PurchaseDate"),
                            PurchasePrice = reader.GetDecimal("PurchasePrice"),

                            CurrentOdometerReading = reader.GetInt32("CurrentOdometerReading"),
                            CurrentStatus = reader.GetString("CurrentStatus"),
                            DailyRate = reader.GetDecimal("DailyRate"),

                            ImagePath = reader.GetString("ImagePath"),

                            IsActive = reader.GetBoolean("IsActive"),
                            CreatedDate = reader.GetDateTime("CreatedDate"),
                            LastModifiedDate = reader.GetDateTime("LastModifiedDate")
                        }); ;
                    }
                }
            }

            return vehicles;
        }


        public void AddVehicle(Vehicle vehicle) {
            MySqlConnection conn = MySQLConnectionContext.Create();
            conn.Open();

            string sql = @"
                INSERT INTO Vehicles (
                    VIN,
                    LicensePlate,
                    Manufacturer,
                    Model,
                    YearModel,
                    Color,
                    Category,
                    PurchaseDate,
                    PurchasePrice,
                    CurrentOdometerReading,
                    CurrentStatus,
                    DailyRate,
                    FuelType,
                    Transmission,
                    SeatingCapacity,
                    ImagePath,
                    IsActive
                )
                VALUES (
                    @vin,
                    @licensePlate,
                    @manufacturer,
                    @model,
                    @yearModel,
                    @color,
                    @category,
                    @purchaseDate,
                    @purchasePrice,
                    @odometer,
                    @status,
                    @dailyRate,
                    @fuelType,
                    @transmission,
                    @seatingCapacity,
                    @imagePath,
                    @isActive
                );
            ";

            MySqlCommand cmd = new MySqlCommand(sql, conn);

            cmd.Parameters.AddWithValue("@vin", vehicle.VIN);
            cmd.Parameters.AddWithValue("@licensePlate", vehicle.LicensePlate);
            cmd.Parameters.AddWithValue("@manufacturer", vehicle.Manufacturer);
            cmd.Parameters.AddWithValue("@model", vehicle.Model);
            cmd.Parameters.AddWithValue("@yearModel", vehicle.YearModel);
            cmd.Parameters.AddWithValue("@color", vehicle.Color);
            cmd.Parameters.AddWithValue("@category", vehicle.Category);
            cmd.Parameters.AddWithValue("@purchaseDate", vehicle.PurchaseDate);
            cmd.Parameters.AddWithValue("@purchasePrice", vehicle.PurchasePrice);
            cmd.Parameters.AddWithValue("@odometer", vehicle.CurrentOdometerReading);
            cmd.Parameters.AddWithValue("@status", vehicle.CurrentStatus);
            cmd.Parameters.AddWithValue("@dailyRate", vehicle.DailyRate);
            cmd.Parameters.AddWithValue("@fuelType", vehicle.FuelType);
            cmd.Parameters.AddWithValue("@transmission", vehicle.Transmission);
            cmd.Parameters.AddWithValue("@seatingCapacity", vehicle.SeatingCapacity);
            cmd.Parameters.AddWithValue("@imagePath", vehicle.ImagePath);
            cmd.Parameters.AddWithValue("@isActive", vehicle.IsActive);

            cmd.ExecuteNonQuery();

            conn.Close();
        }


    }
}
