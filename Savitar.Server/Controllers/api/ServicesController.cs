using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Server.Controllers.api
{
    [AllowAnonymous]
    public class ServicesController : BaseApiEntityController<Service, IServicesRepository>
    {
        public ServicesController(IServicesRepository repository) : base(repository) { }        
    }
}
