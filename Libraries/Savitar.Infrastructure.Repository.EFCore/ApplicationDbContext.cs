using IdentityServer4.EntityFramework.Options;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Options;
using Savitar.Domain.Models;
using Savitar.Domain.Models.CV;
using Savitar.Infrastructure.Repository.EFCore.TypeConfigurations;
using System;
using System.Xml.Linq;

namespace Savitar.Infrastructure.Repository.EFCore
{
    public class ApplicationDbContext : IdentityDbContext<ApplicationUser, IdentityRole<Guid>, Guid>
    {
        public ApplicationDbContext(DbContextOptions options, IOptions<OperationalStoreOptions> operationalStoreOptions) : base(options)
        {
        }

        public DbSet<Service> Services { get; set; }
        public DbSet<ProjectTechnologyCategory> ProjectTechnologyCategories { get; set; }

        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

            builder.ApplyConfiguration(new ServiceTypeConfiguration()); ;
            builder.ApplyConfiguration(new ProjectTechnologyCategoryTypeConfiguration());
            builder.ApplyConfiguration(new ProjectTechnologyTypeConfiguration());

            var sysAdminUser = SeedUsers(builder);
            var sysAdminRole = SeedRoles(builder);
            SeedUserRoles(builder, sysAdminUser, sysAdminRole);
        }

        private static ApplicationUser SeedUsers(ModelBuilder builder)
        {
            ApplicationUser user = new()
            {
                Id = Guid.NewGuid(),
                UserName = "msmit@savitar.co.za",
                Email = "msmit@savitar.co.za",
                LockoutEnabled = false,
                FirstName = "Michael",
                LastName = "Smit",
                EmailConfirmed = true,
                SecurityStamp = Guid.NewGuid().ToString()
        };
            user.NormalizedUserName = user.UserName.ToUpperInvariant();
            user.NormalizedEmail = user.Email.ToUpperInvariant();
            
            PasswordHasher<ApplicationUser> passwordHasher = new();
            user.PasswordHash = passwordHasher.HashPassword(user, "SysAdmin*123");
            
            builder.Entity<ApplicationUser>().HasData(user);

            return user;
        }

        private IdentityRole<Guid> SeedRoles(ModelBuilder builder)
        {
            var sysAdminRole = new IdentityRole<Guid>()
            {
                Id = Guid.NewGuid(), Name = "System Administrator", ConcurrencyStamp = "1", NormalizedName = "System Administrator"
            };

            builder.Entity<IdentityRole<Guid>>().HasData(
                sysAdminRole,
                new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Administrator", ConcurrencyStamp = "2", NormalizedName = "Administrator" },
                new IdentityRole<Guid> { Id = Guid.NewGuid(), Name = "Guest", ConcurrencyStamp = "3", NormalizedName = "Guest" }
            );

            return sysAdminRole;
        }

        private static void SeedUserRoles(ModelBuilder builder, ApplicationUser sysAdminUser, IdentityRole<Guid> sysAdminRole)
        {
            builder.Entity<IdentityUserRole<Guid>>().HasData(new IdentityUserRole<Guid>() { UserId = sysAdminUser.Id, RoleId = sysAdminRole.Id });
        }
    }
}
