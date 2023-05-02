
using ApiApp.Helpers.Database;
using ApiApp.Models;

namespace ApiApp.Repository
{
    public class PermissionRepository : IPermissionRepository
    {
        private PermisosContext context;
        private bool disposedValue;

        public PermissionRepository(PermisosContext context)
        {
            this.context = context;
        }

        public IEnumerable<Permission> GetPermissions()
        {
            return context.Permissions.ToList();
        }

        public async Task SavePermission(Permission permission)
        {
            await context.AddAsync<Permission>(permission);
        }

        protected virtual void Dispose(bool disposing)
        {
            if (!disposedValue)
            {
                if (disposing)
                {
                    context.Dispose();
                }
                disposedValue = true;
            }
        }

        public void Dispose()
        {
            Dispose(disposing: true);
            GC.SuppressFinalize(this);
        }
    }
}