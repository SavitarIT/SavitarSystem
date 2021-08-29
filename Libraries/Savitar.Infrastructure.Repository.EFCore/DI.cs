using Microsoft.Extensions.DependencyInjection;
using Savitar.Domain.Models.Entities;
using Savitar.Domain.Models.Entities.CV;
using Savitar.Infrastructure.Repository.Shared;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public static class DI
    {
        public static void Execute(IServiceCollection services)
        {
            services.AddScoped<IRepository<Service>, Repository<Service>>();
            services.AddScoped<IRepository<ProjectTechnology>, Repository<ProjectTechnology>>();
            services.AddScoped<IRepository<Project>, Repository<Project>>();
            services.AddScoped<IRepository<ApplicationUser>, Repository<ApplicationUser>>();
        }
    }
}
