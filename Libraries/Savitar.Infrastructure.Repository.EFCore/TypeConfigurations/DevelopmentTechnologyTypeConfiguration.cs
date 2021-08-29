using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
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

            builder.HasMany(x => x.PortfolioProjects)
                .WithMany(x => x.DevelopmentTechnologies);
        }
    }
}
