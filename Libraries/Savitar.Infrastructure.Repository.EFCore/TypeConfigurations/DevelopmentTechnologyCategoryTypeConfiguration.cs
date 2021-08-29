using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class DevelopmentTechnologyCategoryTypeConfiguration : IEntityTypeConfiguration<DevelopmentTechnologyCategory>
    {
        public void Configure(EntityTypeBuilder<DevelopmentTechnologyCategory> builder)
        {
            builder
                .ToTable("DevelopmentTechnologyCategories")
                .HasIndex(x => x.Name);

            var seedData = SeedData.DevelopmentTechnologyCategories.GetAll()
                .Select(x => new
                {
                    x.Id,
                    x.Name
                });

            builder.HasData(seedData);
        }
    }
}
