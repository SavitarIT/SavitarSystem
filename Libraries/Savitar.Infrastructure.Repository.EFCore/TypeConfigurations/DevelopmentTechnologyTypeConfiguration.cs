using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Linq;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class DevelopmentTechnologyTypeConfiguration : IEntityTypeConfiguration<DevelopmentTechnology>
    {
        public void Configure(EntityTypeBuilder<DevelopmentTechnology> builder)
        {
            builder
                .ToTable("DevelopmentTechnologies")
                .HasIndex(x => x.Name);


            builder.HasOne(x => x.DevelopmentTechnologyCategory)
                .WithMany(x => x.Technologies)
                .IsRequired();

            builder.HasMany(x => x.Projects)
                .WithMany(x => x.DevelopmentTechnologies);
                

            var seedData = SeedData.ProjectTechnologiesSeedData.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.FirstUse,
                    x.LastUse,
                    x.UsageFrequency,
                    x.Proficiency,
                    DevelopmentTechnologyCategoryId = x.DevelopmentTechnologyCategory.Id
                });

            builder.HasData(seedData);
        }
    }
}
