using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.Entities.CV;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class PortfolioController : BaseApiEntityController<Project, IPortfolioRepository, PortfolioController>
    {
        public PortfolioController(IPortfolioRepository repository) : base(repository) { }
    }
}