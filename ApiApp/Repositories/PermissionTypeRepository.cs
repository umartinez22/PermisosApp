using ApiApp.Models;
using ApiApp.Helpers.Database;
namespace ApiApp.Repository
{
    public class PermissionTypeReposotory : IPermissionTypeRepository
    {
        private bool disposedValue;
        private PermisosContext context;

        public PermissionTypeReposotory(PermisosContext context)
        {
            this.context = context;
        }

        public IEnumerable<PermissionType> GetPermissionTypes()
        {
            return context.PermissionTypes.ToList();
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