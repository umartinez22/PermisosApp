
using ApiApp.Helpers.Database;
using ApiApp.Models;
using Microsoft.EntityFrameworkCore;

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
            return context.Permissions.Include(permission => permission.UserPermission);
        }

        public async Task SavePermission(Permission permission)
        {
            context.Permissions.Attach(permission);
            await context.SaveChangesAsync();
        }

        public async Task DeletePermission(Permission permission)
        {
            context.Permissions.Remove(permission);
            await context.SaveChangesAsync();
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