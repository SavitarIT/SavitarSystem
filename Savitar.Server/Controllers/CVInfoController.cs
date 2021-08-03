using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.Web.Domain.Models;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Savitar.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class CVInfoController : ControllerBase
    {
        private readonly ILogger<EthFunctionsController> _logger;

        public CVInfoController(IEthereumService ethereumService, ILogger<EthFunctionsController> logger)
        {
            EthereumService = ethereumService;
            _logger = logger;
        }

        public IEthereumService EthereumService { get; }

        [HttpGet("GetProjects")]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            var result = new List<Project>
            {
                new Project { Id = 1, Name = "Some Name" },
                new Project { Id = 2, Name = "Another Name" }
            };

            return await Task.FromResult(result.ToArray());
        }                    
    }
}
