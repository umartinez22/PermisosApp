
using ApiApp.Models;

namespace ApiApp.Services
{
    public interface IPermissionService
    {
        IEnumerable<Permission> GetPermissions();
        void SavePermission(Permission permission);
    }
}