using System.Threading.Tasks;
using Savitar.Domain.Models;
using Savitar.Domain.Models.Entities;
using Savitar.Domain.Models.Parameters;

namespace Savitar.Web.Client.Services.Contracts
{
    public interface IAuthorizeApi
    {
        Task Login(LoginParameters loginParameters);
        Task Register(RegisterParameters registerParameters);
        Task Logout();
        Task<UserInfo> GetUserInfo();
    }
}
