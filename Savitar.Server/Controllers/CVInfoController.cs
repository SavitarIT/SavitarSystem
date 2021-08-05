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
        public IClientsAndProjects ClientsAndProjectsService { get; }
        public ITechnologies TechnologiesService { get; }        

        public CVInfoController(IClientsAndProjects clientsAndProjectsService, ITechnologies technologiesService, ILogger<EthFunctionsController> logger)
        {
            ClientsAndProjectsService = clientsAndProjectsService;
            TechnologiesService = technologiesService;            

            _logger = logger;
        }
        
        [HttpGet("GetProjects")]
        [ResponseCache(NoStore = false, Duration = 10, Location = ResponseCacheLocation.Any)]
        public async Task<IEnumerable<Project>> GetProjects()
        {
            var result = ClientsAndProjectsService.GetAll()
                .Select(x => x.Projects)
                .SelectMany(x => x)
                .OrderBy(x => x.Name).ToList();
            
            return await Task.FromResult(result.ToArray());
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
