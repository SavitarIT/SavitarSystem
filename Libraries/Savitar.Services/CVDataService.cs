using Savitar.Domain.Models.CV;
using Savitar.Services.Shared;
using System.Linq;
using System.Threading.Tasks;
using Savitar.Infrastructure.Repository.Shared.CV;

namespace Savitar.Services
{
    internal class CVDataService : ICVDataService
    {        
        private readonly ITechnologies technologies;        

        public CVDataService(ITechnologies technologies)
        {     
            this.technologies = technologies;            
        }

        public Task<ProjectTechnology[]> GetProjectTechnologies()
        {
            return Task.FromResult(technologies.GetAll().ToArray());
        }        
    }
}
