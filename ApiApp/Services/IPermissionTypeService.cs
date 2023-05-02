using ApiApp.Models;

namespace ApiApp.Services
{
    public interface IPermissionTypeService
    {
        IEnumerable<PermissionType> GetPermissionTypes();
    }
}