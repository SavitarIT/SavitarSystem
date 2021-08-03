using Savitar.Domain.Models;
using System.Threading.Tasks;

namespace Savitar.Services.Contracts
{
    public interface ICVDataService
    {
        Task<Client[]> GetClientsAsync();
        Task<ProjectTechnology[]> GetProjectTechnologies();
        Task<Service[]> GetServicesAsync();
    }
}
