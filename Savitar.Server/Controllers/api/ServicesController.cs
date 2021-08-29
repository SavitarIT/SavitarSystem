using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.Entities;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class ServicesController : BaseApiEntityController<Service, ServicesController>
    {
        public ServicesController(IRepository<Service> repository) : base(repository)
        {
        }
    }
}
