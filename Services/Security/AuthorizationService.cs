using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PL_VehicleRental.Services.Security
{
    public static class AuthorizationService
    {
        public static bool HasPermission(Permission permission)
        {
            if (Session.User == null) return false;
            if (Session.User.Role == UserRole.Superadmin) return true;

            if (RolePermissionMap.Map.TryGetValue(Session.User.Role, out var permissions))
            {
                return permissions.Contains(permission);
            }

            return false;
        }

        public static bool CanModifyUser(string targetRole)
        {
            if (Session.User.Role == UserRole.Superadmin) return true;
            if (Session.User.Role == UserRole.Admin && targetRole == UserRole.Superadmin.ToString())
                return false;

            return true;
        }
    }
}
