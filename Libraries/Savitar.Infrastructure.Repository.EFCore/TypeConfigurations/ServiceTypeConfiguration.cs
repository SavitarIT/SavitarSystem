using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities;

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
}
