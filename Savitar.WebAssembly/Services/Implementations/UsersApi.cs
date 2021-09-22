using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using Savitar.Domain.Models.Dtos;
using Savitar.Web.Client.Services.Contracts;

namespace Savitar.Web.Client.Services.Implementations
{
    internal class UsersApi : BaseApi, IUsersApi
    {
        public UsersApi(HttpClient httpClient) : base(httpClient) { }

        public async Task SaveAsync(User user)
        {
            HttpResponseMessage result;

            if (user.Id <= 0)
                result = await HttpClient.PostAsJsonAsync("api/sysadmin/users", user);
            else
                result = await HttpClient.PutAsJsonAsync($"api/sysadmin/users/{user.Id}", user);

            if (result.StatusCode == System.Net.HttpStatusCode.BadRequest)
                throw new Exception(await result.Content.ReadAsStringAsync());

            result.EnsureSuccessStatusCode();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await HttpClient.GetFromJsonAsync<User[]>("api/sysadmin/users");
        }
    }
}