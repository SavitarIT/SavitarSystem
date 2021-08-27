using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Savitar.Domain.Requests;
using Savitar.Domain.Shared.Wrapper;
using Savitar.Server.Shared.Endpoints;
using Savitar.Web.Client.Infrastructure.Extensions;
using Savitar.Web.Client.Services.Contracts;

namespace Savitar.Web.Client.Services.Implementations
{
    public class AccountsApi : IAccountsApi
    {
        private readonly HttpClient _httpClient;

        public AccountsApi(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult> ChangePasswordAsync(ChangePasswordRequest model)
        {
            var response = await _httpClient.PutAsJsonAsync(AccountEndpoints.ChangePassword, model);
            return await response.ToResult();
        }

        public async Task<IResult> UpdateProfileAsync(UpdateProfileRequest model)
        {
            var response = await _httpClient.PutAsJsonAsync(AccountEndpoints.UpdateProfile, model);
            return await response.ToResult();
        }

        public async Task<IResult<string>> GetUserProfile(Guid userId)
        {
            var response = await _httpClient.GetAsync(AccountEndpoints.GetUserProfile(userId));
            return await response.ToResult<string>();
        }
    }
}