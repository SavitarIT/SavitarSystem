using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.Web.Domain.Dtos;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using System.Threading.Tasks;

namespace Savitar.Server.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    [Produces("application/json")]
    public class EthFunctionsController : ControllerBase
    {
        private readonly ILogger<EthFunctionsController> _logger;

        public EthFunctionsController(IEthereumService ethereumService, ILogger<EthFunctionsController> logger)
        {
            EthereumService = ethereumService;
            _logger = logger;
        }

        public IEthereumService EthereumService { get; }

        [HttpGet("GetAll")]
        public async Task<EthInfo> GetAll()
        {
            var result = new EthInfo()
            {
                LatestBlockNumber = await EthereumService.GetLatestBlockNumberAsync(),
                Balance = await EthereumService.GetBalanceAsync(),
                NetworkVersion = await EthereumService.GetNetworkVersionAsync()
            };

            return result;
        }                    
    }
}
