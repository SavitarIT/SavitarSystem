using System;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Savitar.Domain.Models.Dtos;
using Savitar.Domain.Models.Parameters;
using Savitar.Server.Shared.Endpoints;
using Savitar.Web.Client.Services.Contracts;

namespace Savitar.Web.Client.Services.Implementations
{
    public class AuthorizeApi : BaseApi, IAuthorizeApi
    {
        public AuthorizeApi(HttpClient httpClient) : base(httpClient)
        {
        }

        public async Task Login(LoginParameters loginParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(loginParameters), Encoding.UTF8, "application/json");
            var result = await HttpClient.PostAsJsonAsync(AuthorizeEndpoints.Login, loginParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task Logout()
        {
            var result = await HttpClient.PostAsync(AuthorizeEndpoints.Logout, null);
            result.EnsureSuccessStatusCode();
        }

        public async Task Register(RegisterParameters registerParameters)
        {
            //var stringContent = new StringContent(JsonSerializer.Serialize(registerParameters), Encoding.UTF8, "application/json");
            var result = await HttpClient.PostAsJsonAsync(AuthorizeEndpoints.Register, registerParameters);
            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest) throw new Exception(await result.Content.ReadAsStringAsync());
            result.EnsureSuccessStatusCode();
        }

        public async Task<UserInfo> GetUserInfo()
        {
            var result = await HttpClient.GetFromJsonAsync<UserInfo>(AuthorizeEndpoints.UserInfo);
            return result;
        }
    }
}
