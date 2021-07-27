using Microsoft.Extensions.DependencyInjection;

namespace Savitar.Web.Bootstrapper
{
    public static class Bootstrap
    {
        public static IServiceCollection AddSavitarServices(this IServiceCollection services)
        {
            Data.DI.Execute(services);
            Services.DI.Execute(services);
            
            return services;
        }
    }
}
