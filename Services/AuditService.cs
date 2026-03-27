using VehicleManagementSystem.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Dto;
using MySqlConnector;

namespace PL_VehicleRental.Services
{
    public class AuditService
    {
        public static async Task LogAsync(AuditLog log)
        {
            string query = @"INSERT INTO AuditLogs
                            (userId, actionType, description, tableAffected, recordId)
                            VALUES
                            (@userId, @actionType, @description, @tableAffected, @recordId)";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                cmd.Parameters.AddWithValue("@userId", log.UserId);
                cmd.Parameters.AddWithValue("@actionType", log.ActionType);
                cmd.Parameters.AddWithValue("@description", log.Description);
                cmd.Parameters.AddWithValue("@tableAffected", log.TableAffected);
                cmd.Parameters.AddWithValue("@recordId", log.RecordId);

                await conn.OpenAsync();
                await cmd.ExecuteNonQueryAsync();
            }
        }

        public async Task<List<AuditLog>> GetAuditLogsAsync()
        {
            var logs = new List<AuditLog>();

            string query = @"SELECT 
                            a.id, u.userName, a.actionType, a.description, a.tableAffected, a.createdAt
                            FROM AuditLogs a 
                            LEFT JOIN users u ON u.id = a.userId
                            ORDER BY a.createdAt DESC";

            using (var conn = MySQLConnectionContext.Create())
            using (var cmd = new MySqlCommand(query, conn))
            {
                await conn.OpenAsync();
                
                using (var reader = await cmd.ExecuteReaderAsync())
                {
                    while(await reader.ReadAsync())
                    {
                        var dbTime = reader.GetDateTime("createdAt");
                        var phTimeZone = TimeZoneInfo.FindSystemTimeZoneById("Singapore Standard Time");

                        logs.Add(new AuditLog
                        {
                            UserId = reader.GetInt32("id"), 
                            UserName = reader.IsDBNull(reader.GetOrdinal("userName")) 
                                        ? "Unknown User" 
                                        : reader.GetString("userName"),
                            
                            ActionType = reader.IsDBNull(reader.GetOrdinal("actionType")) 
                                        ? string.Empty 
                                        : reader.GetString("actionType"),
                            
                            Description = reader.IsDBNull(reader.GetOrdinal("description")) 
                                        ? string.Empty 
                                        : reader.GetString("description"),
                            
                            TableAffected = reader.IsDBNull(reader.GetOrdinal("tableAffected")) 
                                        ? string.Empty 
                                        : reader.GetString("tableAffected"),

                            CreatedAt = TimeZoneInfo.ConvertTimeFromUtc(
                            DateTime.SpecifyKind(dbTime, DateTimeKind.Utc),
                            phTimeZone
                        )
                        });
                    }
                }
            }
            return logs;
        }
    }
}
