using Microsoft.Extensions.DependencyInjection;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddScoped<IProjectTechnologiesRepository, ProjectTechnologiesRepository>();
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IPortfolioRepository, PortfolioRepository>();
        }
    }
}
