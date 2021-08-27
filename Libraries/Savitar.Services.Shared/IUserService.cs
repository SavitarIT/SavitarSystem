using Savitar.Domain.Models;
using Savitar.Domain.Shared.Wrapper;
using System.Threading.Tasks;

namespace Savitar.Services.Shared
{
    public interface IUserService
    {
        Task<IResult> Login(LoginParameters model);
        Task Logout();
        Task<IResult> Register(RegisterParameters model);
    }
}
