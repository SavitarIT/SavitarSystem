using Microsoft.Extensions.DependencyInjection;
using Savitar.Infrastructure.Repository.Shared.CV;
using Savitar.Infrastructure.Repository.CV;

namespace Savitar.Infrastructure.Repository
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddSingleton<IClientsAndProjects, ClientsAndProjects>();
            services.AddSingleton<ITechnologies, Technologies>();
            services.AddSingleton<IServices, Services>();
        }
    }
}
