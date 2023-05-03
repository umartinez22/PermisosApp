
using ApiApp.Models;

namespace ApiApp.Repository
{
    public interface IPermissionRepository : IDisposable
    {
        IEnumerable<Permission> GetPermissions();
        Task SavePermission(Permission permission);
        Task DeletePermission(Permission permission);
    }
}