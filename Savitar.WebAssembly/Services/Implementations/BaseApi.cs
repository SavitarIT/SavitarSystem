using System.Net.Http;
using Savitar.Web.Client.Services.Contracts;

namespace Savitar.Web.Client.Services.Implementations
{
    public class BaseApi : IBaseApi
    {
        public HttpClient HttpClient { get; }

        public BaseApi(HttpClient httpClient)
        {
            HttpClient = httpClient;
        }
    }
}