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

        public Task SaveAsync(User user)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<User>> GetAllUsersAsync()
        {
            return await HttpClient.GetFromJsonAsync<User[]>("api/sysadmin/users");
        }
    }
}