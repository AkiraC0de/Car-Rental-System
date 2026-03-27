using PL_VehicleRental.Services.Security;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VehicleManagementSystem.Services.Security
{
    public static class PermissionService
    {
        public static bool HasPermission(Permission permission)
        {
            var role = Session.User.Role;

            return RolePermissionMap.Map.ContainsKey(role) &&
                   RolePermissionMap.Map[role].Contains(permission);
        }
    }
}
