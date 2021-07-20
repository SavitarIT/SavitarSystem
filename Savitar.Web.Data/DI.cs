using Microsoft.Extensions.DependencyInjection;
using Savitar.Web.Data.Contracts;

namespace Savitar.Web.Data
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
