using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.WebAssembly.Blockchain.Ethereum.Services.Contracts;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Authorization;
using Savitar.Domain.Models.Dtos;
using Savitar.Web.Server.Controllers.api.Base;

namespace Savitar.Web.Server.Controllers.api
{
    [AllowAnonymous]
    public class EthFunctionsController : BaseApiController<EthFunctionsController>
    {
        private readonly ILogger<EthFunctionsController> _logger;

        public EthFunctionsController(IEthereumService ethereumService, ILogger<EthFunctionsController> logger)
        {
            EthereumService = ethereumService;
            _logger = logger;
        }

        public IEthereumService EthereumService { get; }

        [HttpGet("GetAll")]
        [ResponseCache(NoStore = false, Duration = 10, Location = ResponseCacheLocation.Any)]
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
