using Savitar.Web.Domain.Models;
using System.Threading.Tasks;

namespace Savitar.Web.Services.Contracts
{
    public interface ICVDataService
    {
        Task<Client[]> GetClientsAsync();
        Task<ProjectTechnology[]> GetProjectTechnologies();
        Task<Service[]> GetServicesAsync();
    }
}
