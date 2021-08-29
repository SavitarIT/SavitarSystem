using System.Collections.Generic;
using System.Threading.Tasks;
using Savitar.Domain.Models.Dtos;

namespace Savitar.Web.Client.Services.Contracts
{
    public interface IUsersApi : IBaseApi
    {
        Task SaveAsync(User user);
        Task<IEnumerable<User>> GetAllUsersAsync();
    }
}