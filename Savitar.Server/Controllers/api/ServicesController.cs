using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Server.Controllers.api.Base;

namespace Savitar.Server.Controllers.api
{
    [AllowAnonymous]
    public class ServicesController : ApiEntityController<Service, IServicesRepository>
    {
        public ServicesController(IServicesRepository repository) : base(repository) { }        
    }
}
