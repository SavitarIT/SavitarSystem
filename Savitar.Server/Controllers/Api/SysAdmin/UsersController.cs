using Microsoft.AspNetCore.Mvc;
using Savitar.Domain.Models.Entities;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.Api.SysAdmin
{
    [Route("api/sysadmin/[controller]")]
    public class UsersController : BaseApiEntityController<ApplicationUser, UsersController>
    {
        public UsersController(IRepository<ApplicationUser> repository) : base(repository) {  }
    }
}