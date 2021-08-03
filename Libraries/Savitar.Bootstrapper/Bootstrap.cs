using Microsoft.Extensions.DependencyInjection;

namespace Savitar.Bootstrapper
{
    public static class Bootstrap
    {
        public static IServiceCollection AddSavitarServices(this IServiceCollection services)
        {
            Infrastructure.Repository.DI.Execute(services);
            Services.DI.Execute(services);
            
            return services;
        }
    }
}
