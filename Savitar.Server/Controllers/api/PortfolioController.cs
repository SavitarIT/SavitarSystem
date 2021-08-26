using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Server.Controllers.api
{
    [AllowAnonymous]
    public class PortfolioController : BaseApiEntityController<Project, IPortfolioRepository>
    {
        public PortfolioController(IPortfolioRepository repository) : base(repository) { }
    }
}