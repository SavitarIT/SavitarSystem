using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models;
using Savitar.Domain.Models.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class ServiceTypeConfiguration : IEntityTypeConfiguration<Service>
    {
        public void Configure(EntityTypeBuilder<Service> builder)
        {
            builder
                .ToTable("Services")
                .HasIndex(x => x.Title);
            builder.HasData(SeedData.ServicesSeedData.GetAll());
        }
    }

    internal class ProjectTechnologyCategoryTypeConfiguration : IEntityTypeConfiguration<ProjectTechnologyCategory>
    {
        public void Configure(EntityTypeBuilder<ProjectTechnologyCategory> builder)
        {
            builder
                .ToTable("ProjectTechnologyCategories")
                .HasIndex(x => x.Name);
            builder.HasData(SeedData.ProjectTechnologyCategories.GetAll());
        }
    }
}
