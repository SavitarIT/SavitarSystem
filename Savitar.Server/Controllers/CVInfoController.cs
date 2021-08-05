using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.Shared.CV;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Savitar.Server.Controllers
{
    public class CVInfoController : BaseApiController
    {
        private readonly ILogger<EthFunctionsController> _logger;
        public ITechnologies TechnologiesService { get; }        

        public CVInfoController(ITechnologies technologiesService, ILogger<EthFunctionsController> logger)
        {            
            TechnologiesService = technologiesService;            

            _logger = logger;
        }
        
        [HttpGet("GetTechnologies")]
        [ResponseCache(NoStore = false, Duration = 10, Location = ResponseCacheLocation.Any)]
        public async Task<IEnumerable<ProjectTechnology>> GetTechnologies()
        {
            var result = TechnologiesService.GetAll();
            return await Task.FromResult(result.ToArray());
        }        
    }
}
