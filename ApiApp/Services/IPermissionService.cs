
using ApiApp.Models;

namespace ApiApp.Services
{
    public interface IPermissionService
    {
        IEnumerable<Permission> GetPermissions();
        Task SavePermission(Permission permission);
        Task DeletePermission(Permission permission);
        Task UpdatePermission(Permission permission);
    }
}