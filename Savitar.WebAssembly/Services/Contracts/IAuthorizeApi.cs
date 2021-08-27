using System.Threading.Tasks;
using Savitar.Domain.Models;
using Savitar.Domain.Models.Entities;

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
