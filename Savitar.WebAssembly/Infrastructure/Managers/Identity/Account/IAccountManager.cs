using System.Threading.Tasks;
using Savitar.Domain.Requests;
using Savitar.Domain.Shared;
using Savitar.Domain.Shared.Wrapper;

namespace Savitar.WebAssembly.Infrastructure.Managers.Identity.Account
{
    public interface IAccountManager : IManager
    {
        Task<IResult> ChangePasswordAsync(ChangePasswordRequest model);

        Task<IResult> UpdateProfileAsync(UpdateProfileRequest model);

        Task<IResult<string>> GetProfilePictureAsync(string userId);

        Task<IResult<string>> UpdateProfilePictureAsync(UpdateProfilePictureRequest request, string userId);
    }
}