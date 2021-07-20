using Savitar.Web.Server.Models;
using Savitar.Web.Services.Contracts;
using Savitar.Web.Services.Data;
using System.Linq;
using System.Threading.Tasks;

namespace Savitar.Web.Services
{
    public class CVDataService : ICVDataService
    {
        public Task<Client[]> GetClientsAsync()
        {
            return Task.FromResult(ClientsAndProjects.GetAll().ToArray());
        }

        public Task<ProjectTechnology[]> GetProjectTechnologies()
        {
            return Task.FromResult(Technologies.GetAll().ToArray());
        }

        public Task<Service[]> GetServicesAsync()
        {
            return Task.FromResult(Data.Services.GetAll().ToArray());
        }
    }
}
