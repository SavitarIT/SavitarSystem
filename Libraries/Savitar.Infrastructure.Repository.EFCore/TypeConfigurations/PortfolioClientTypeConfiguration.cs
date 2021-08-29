using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class PortfolioClientTypeConfiguration : IEntityTypeConfiguration<PortfolioClient>
    {
        public void Configure(EntityTypeBuilder<PortfolioClient> builder)
        {
            builder
                .ToTable("PortfolioClients")
                .HasIndex(x => x.Name);

            builder
                .HasMany(x => x.PortfolioProjects)
                .WithOne(x => x.PortfolioClient);
        }
    }
}