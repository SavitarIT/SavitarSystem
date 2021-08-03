using Savitar.Domain.Models;
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
        private readonly IServices services;

        public CVDataService(IClientsAndProjects clientsAndProjects, ITechnologies technologies, IServices services)
        {
            this.clientsAndProjects = clientsAndProjects;
            this.technologies = technologies;
            this.services = services;
        }

        public Task<Client[]> GetClientsAsync()
        {
            return Task.FromResult(clientsAndProjects.GetAll().ToArray());
        }

        public Task<ProjectTechnology[]> GetProjectTechnologies()
        {
            return Task.FromResult(technologies.GetAll().ToArray());
        }

        public Task<Service[]> GetServicesAsync()
        {
            return Task.FromResult(services.GetAll().ToArray());
        }
    }
}
