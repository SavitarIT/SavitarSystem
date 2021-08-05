using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.CV;
using System.Linq;

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
