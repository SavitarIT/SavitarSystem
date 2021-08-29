using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class ProjectTechnologyTypeConfiguration : IEntityTypeConfiguration<ProjectTechnology>
    {
        public void Configure(EntityTypeBuilder<ProjectTechnology> builder)
        {
            builder
                .ToTable("ProjectTechnologies")
                .HasIndex(x => x.Name);


            builder.HasOne(x => x.Category)
                .WithMany(x => x.Technologies)
                .IsRequired();

            builder.HasMany(x => x.Projects)
                .WithMany(x => x.TechStack);

            var seedData = SeedData.ProjectTechnologiesSeedData.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.FirstUse,
                    x.LastUse,
                    x.UsageFrequency,
                    x.Proficiency,
                    CategoryId = x.Category.Id
                });

            builder.HasData(seedData);
        }
    }
}
