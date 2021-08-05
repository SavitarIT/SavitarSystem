using Savitar.Domain.Models.CV;
using System.Threading.Tasks;

namespace Savitar.Services.Shared
{
    public interface ICVDataService
    {
        Task<Client[]> GetClientsAsync();
        Task<ProjectTechnology[]> GetProjectTechnologies();        
    }
}
