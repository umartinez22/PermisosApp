using ApiApp.Models;
using ApiApp.Repository;

namespace ApiApp.Services
{
    public class PermissionTypeService : IPermissionTypeService
    {
        IPermissionTypeRepository repository;
        public PermissionTypeService(IPermissionTypeRepository repository)
        {
            this.repository = repository;
        }

        public IEnumerable<PermissionType> GetPermissionTypes()
        {
            return repository.GetPermissionTypes();
        }
    }
}