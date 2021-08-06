using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.Logging;
using System.Threading.Tasks;

namespace Savitar.Server.Controllers
{
    public class AccountsController : BaseApiController
    {
        private readonly ILogger<AccountsController> _logger;
        private IConfiguration Configuration { get; init; }
        public AccountsController(IConfiguration config, ILogger<AccountsController> logger)
        {
            _logger = logger;
            Configuration = config;
        }

        
        [HttpGet]
        [Route("IsValid/{password}")]
        public async Task<bool> IsValid([FromRoute] string password)
        {
            var expectedPassword = Configuration["Admin:Password"];
            var result = password == expectedPassword;
            return await Task.FromResult(result);
        }                    
    }
}
