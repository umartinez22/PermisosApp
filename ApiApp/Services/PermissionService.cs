
using ApiApp.Repository;
using ApiApp.Models;

namespace ApiApp.Services
{
    public class PermissionService : IPermissionService
    {
        private IPermissionRepository repository;

        public PermissionService(IPermissionRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<Permission> GetPermissions()
        {
            return repository.GetPermissions();
        }

        public async Task SavePermission(Permission permission)
        {
            await repository.SavePermission(permission);
        }

        public async Task DeletePermission(Permission permission)
        {
            await repository.DeletePermission(permission);
        }
    }
}