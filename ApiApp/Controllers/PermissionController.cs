
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

        [HttpGet]
        public IEnumerable<Permission> Get()
        {
            return service.GetPermissions();
        }

        [HttpPost]
        public async void Post([FromBody] Permission permission)
        {
            await service.SavePermission(permission);
        }

        [HttpDelete]
        public async void Delete([FromBody] Permission permission)
        {
            await service.DeletePermission(permission);
        }

        [HttpPut]
        public async void Put([FromBody] Permission permission)
        {
            await service.UpdatePermission(permission);
        }
    }
}