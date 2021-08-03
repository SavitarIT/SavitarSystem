using Microsoft.Extensions.DependencyInjection;
using Savitar.Services.Contracts;

namespace Savitar.Services
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddSingleton<ICVDataService, CVDataService>();
        }
    }
}
