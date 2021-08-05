using Savitar.Domain.Models.CV;
using Savitar.Services.Shared;
using System.Linq;
using System.Threading.Tasks;
using Savitar.Infrastructure.Repository.Shared.CV;

namespace Savitar.Services
{
    internal class CVDataService : ICVDataService
    {
        private readonly IClientsAndProjects clientsAndProjects;
        private readonly ITechnologies technologies;        

        public CVDataService(IClientsAndProjects clientsAndProjects, ITechnologies technologies)
        {
            this.clientsAndProjects = clientsAndProjects;
            this.technologies = technologies;            
        }

        public Task<Client[]> GetClientsAsync()
        {
            return Task.FromResult(clientsAndProjects.GetAll().ToArray());
        }

        public Task<ProjectTechnology[]> GetProjectTechnologies()
        {
            return Task.FromResult(technologies.GetAll().ToArray());
        }        
    }
}
