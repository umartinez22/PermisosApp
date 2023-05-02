
using ApiApp.Services;
using Microsoft.AspNetCore.Mvc;
using ApiApp.Models;

namespace ApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class PermissionController
    {
        private IPermissionService service;

        public PermissionController(IPermissionService service)
        {
            this.service = service;
        }

        public IEnumerable<Permission> Get()
        {
            return service.GetPermissions();
        }

        public void Post(Permission permission)
        {
            service.SavePermission(permission);
        }
    }
}