using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Server.Controllers.api.Base;

namespace Savitar.Server.Controllers.api
{
    [AllowAnonymous]
    public class PortfolioController : BaseApiEntityController<Project, IPortfolioRepository, PortfolioController>
    {
        public PortfolioController(IPortfolioRepository repository) : base(repository) { }
    }
}