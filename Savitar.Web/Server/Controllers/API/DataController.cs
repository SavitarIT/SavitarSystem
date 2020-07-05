using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using Savitar.Web.Client.Pages;
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
        public IEnumerable<Shared.Models.Client> GetClients()
        {
            return ClientsAndProjects.GetAll();
        }

        [HttpGet]
        [Route("GetProjectTechnologies")]
        public IEnumerable<Shared.Models.ProjectTechnology> GetProjectTechnologies()
        {
            return Technologies.GetAll();
        }

        [HttpGet]
        [Route("GetServices")]
        public IEnumerable<Shared.Models.Service> GetServices()
        {
            return Data.Services.GetAll();
        }
    }
}
