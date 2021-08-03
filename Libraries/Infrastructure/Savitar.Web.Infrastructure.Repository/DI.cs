using Microsoft.Extensions.DependencyInjection;
using Savitar.Web.Infrastructure.Repository.Contracts.CV;
using Savitar.Web.Infrastructure.Repository.CV;

namespace Savitar.Web.Infrastructure.Repository
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
