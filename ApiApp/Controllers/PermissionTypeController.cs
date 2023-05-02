
using ApiApp.Models;
using ApiApp.Services;
using Microsoft.AspNetCore.Mvc;

namespace ApiApp.Controllers
{

    [ApiController]
    [Route("[controller]")]
    public class PermissionTypeController
    {
        private IPermissionTypeService service;

        public PermissionTypeController(IPermissionTypeService service)
        {
            this.service = service;
        }

        public IEnumerable<PermissionType> Get()
        {
            return service.GetPermissionTypes();
        }
    }
}