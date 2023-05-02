
using ApiApp.Models;

namespace ApiApp.Repository
{
    public interface IPermissionTypeRepository : IDisposable
    {
        IEnumerable<PermissionType> GetPermissionTypes();
    }
}