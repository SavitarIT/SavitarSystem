using Microsoft.Extensions.DependencyInjection;
using Savitar.Web.Server.Shared.Implementations;
using Savitar.Web.Server.Shared.Interfaces;

namespace Savitar.Web.Server.Shared
{
    public static class DI
    {
        public static void AddSavitarServerServices(this IServiceCollection services)
        {
            services.AddHttpContextAccessor();
            services.AddScoped<ICurrentUserService, CurrentUserService>();
        }
    }
}
