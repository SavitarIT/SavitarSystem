using Microsoft.Extensions.DependencyInjection;
using Savitar.Infrastructure.Repository.CV;
using Savitar.Infrastructure.Repository.Shared;
using Savitar.Infrastructure.Repository.Shared.CV;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            //services.AddSingleton<IClientsAndProjects, ClientsAndProjects>();
            services.AddSingleton<ITechnologies, Technologies>();
            
            services.AddScoped<IServicesRepository, ServicesRepository>();
            services.AddScoped<IProjectsRepository, ProjectsRepository>();
        }
    }
}
