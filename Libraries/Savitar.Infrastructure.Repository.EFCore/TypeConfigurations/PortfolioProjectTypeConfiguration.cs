using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class PortfolioProjectTypeConfiguration : IEntityTypeConfiguration<PortfolioProject>
    {
        public void Configure(EntityTypeBuilder<PortfolioProject> builder)
        {
            builder.ToTable("PortfolioProjects")
                .HasIndex(x => x.Name);

            builder.HasOne(x => x.PortfolioClient)
                .WithMany(x => x.PortfolioProjects);

            builder.HasMany(x => x.DevelopmentTechnologies)
                .WithMany(x => x.PortfolioProjects);
        }
    }
}