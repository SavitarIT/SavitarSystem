using System;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class ProjectTypeConfiguration : IEntityTypeConfiguration<Project>
    {
        public void Configure(EntityTypeBuilder<Project> builder)
        {
            builder.ToTable("Projects")
                .HasIndex(x => x.Name);

            builder.HasOne(x => x.Client)
                .WithMany(x => x.Projects);

            builder.HasMany(x => x.TechStack)
                .WithMany(x => x.Projects);

            var seedData = SeedData.ClientsAndProjectsSeedData.GetProjects()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Description,
                    x.Url,
                    ClientId = x.Client.Id
                });

            try
            {
                foreach (var project in seedData)
                {
                    if (project.ClientId == 0)
                        throw new Exception("TEST 2");
                }
            }
            catch (Exception ex)
            {
                throw new Exception($"TEST 3: {ex.Message}");
            }

            builder.HasData(seedData);
        }
    }
}