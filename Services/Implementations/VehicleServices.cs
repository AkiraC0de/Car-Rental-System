using MySqlConnector;
using System;
using VehicleManagementSystem.Data;
using VehicleManagementSystem.Models;
using VehicleManagementSystem.Services.Interfaces;
using VehicleManagementSystem.View.Interfaces;

namespace VehicleManagementSystem.Services.Implementations {
    public class VehicleServices : IVehicleService {

        public void AddVehicle(Vehicle vehicle) {
            var conn = MySQLConnectionContext.Create();
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

            var cmd = new MySqlCommand(sql, conn);

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
        }

    }
}
