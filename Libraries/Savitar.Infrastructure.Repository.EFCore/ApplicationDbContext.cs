using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.ApiAuthorization.IdentityServer;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Savitar.Domain.Models;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.EFCore.TypeConfigurations;
using System;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<ProjectTechnologyCategory> ProjectTechnologyCategories { get; set; }

        //public DbSet<Client> Clients { get; set; }
        //public DbSet<Project> Projects { get; set; }
        //public DbSet<ProjectTechnology> ProjectTechnologies { get; set; }


        protected override void OnModelCreating(ModelBuilder builder)
        {
            builder.ApplyConfiguration(new ServiceTypeConfiguration()); ;
            builder.ApplyConfiguration(new ProjectTechnologyCategoryTypeConfiguration());
            builder.ApplyConfiguration(new ProjectTechnologyTypeConfiguration());

            base.OnModelCreating(builder);
        }
    }
}
