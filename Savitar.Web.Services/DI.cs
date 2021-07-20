using Microsoft.Extensions.DependencyInjection;
using Savitar.Web.Services.Contracts;

namespace Savitar.Web.Services
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddSingleton<ICVDataService, CVDataService>();
        }
    }
}
