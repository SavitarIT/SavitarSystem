using System.Threading.Tasks;
using Savitar.Domain.Requests;
using Savitar.Domain.Shared.Wrapper;

namespace Savitar.WebAssembly.Services.Contracts
{
    public interface IAccountsApi : IManager
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model);

        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model);
    }
}