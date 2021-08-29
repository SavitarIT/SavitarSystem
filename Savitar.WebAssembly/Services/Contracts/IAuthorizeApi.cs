using System.Threading.Tasks;
using Savitar.Domain.Models.Dtos;
using Savitar.Domain.Models.Parameters;

namespace Savitar.Web.Client.Services.Contracts
{
    public interface IAuthorizeApi : IBaseApi
    {
        Task Login(LoginParameters loginParameters);
        Task Register(RegisterParameters registerParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}
