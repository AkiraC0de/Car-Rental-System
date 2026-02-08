using MySqlConnector;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VehicleManagementSystem.Data;

namespace VehicleManagementSystem.Services.Implementations
{
    internal class UserServices
    {
        public DataTable LoadUsers()
        {
            DataTable dt = new DataTable();

            using (MySqlConnection conn = MySQLConnectionContext.Create())
            {
                conn.Open();

                string query = @"SELECT id AS ID, 
                                    userName AS Username, 
                                    fullName AS FullName,
                                    address AS Address,
                                    role As Role, 
                                    status AS Status
                            FROM users";
                using (MySqlCommand cmd = new MySqlCommand(query, conn))
                using (MySqlDataAdapter da = new MySqlDataAdapter(cmd))
                {
                    da.Fill(dt);
                }
            }

            return dt;
        }
    }
}
