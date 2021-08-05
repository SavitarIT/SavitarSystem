using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Savitar.Domain.Models;
using Savitar.Infrastructure.Repository.EFCore.TypeConfigurations;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public class ApplicationDbContext : ApiAuthorizationDbContext<ApplicationUser>
    {
        public ApplicationDbContext(
            DbContextOptions options,
            IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options, operationalStoreOptions)
        {
        }

        public DbSet<Service> Services { get; set; }

        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }
        //public DbSet<ProjectTechnologyCategory> ProjectTechnologyCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ServiceTypeConfiguration()); ;

            

            base.OnModelCreating(builder);
        }
    }
}
