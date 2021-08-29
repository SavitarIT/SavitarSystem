using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class ProjectTechnologyCategoryTypeConfiguration : IEntityTypeConfiguration<ProjectTechnologyCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectTechnologyCategory> builder)
        {
            builder
                .ToTable("ProjectTechnologyCategories")
                .HasIndex(x => x.Name);

            var seedData = SeedData.ProjectTechnologyCategories.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.Name
                });

            builder.HasData(seedData);
        }
    }
}
