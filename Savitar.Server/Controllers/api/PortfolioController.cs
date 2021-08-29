using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.Entities.CV;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class PortfolioController : BaseApiEntityController<Project, PortfolioController>
    {
        public PortfolioController(IRepository<Project> repository) : base(repository)
        {
        }
    }
}