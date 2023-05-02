
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

        public void SavePermission(Permission permission)
        {
            repository.SavePermission(permission);
        }
    }
}