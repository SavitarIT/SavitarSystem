using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.Web.Server.Data;

namespace Savitar.Web.Server.Controllers.API
{
    [Route("api/[controller]")]
    [ApiController]
    public class DataController : ControllerBase
    {
        private readonly ILogger<DataController> _logger;

        public DataController(ILogger<DataController> logger)
        {
            _logger = logger;
        }

        [HttpGet]
        [Route("GetClients")]
        public IEnumerable<Client.Models.Client> GetClients()
        {
            return ClientsAndProjects.GetAll();
        }

        [HttpGet]
        [Route("GetProjectTechnologies")]
        public IEnumerable<Client.Models.ProjectTechnology> GetProjectTechnologies()
        {
            return Technologies.GetAll();
        }

        [HttpGet]
        [Route("GetServices")]
        public IEnumerable<Client.Models.Service> GetServices()
        {
            return Services.GetAll();
        }
    }
}
