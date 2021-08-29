using System.Collections.Generic;
using System.Linq;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Savitar.Domain.Models.Entities.CV;

namespace Savitar.Infrastructure.Repository.EFCore.TypeConfigurations
{
    internal class ClientTypeConfiguration : IEntityTypeConfiguration<Client>
    {
        public void Configure(EntityTypeBuilder<Client> builder)
        {
            builder
                .ToTable("Clients")
                .HasIndex(x => x.Name);

            builder
                .HasMany(x => x.Projects)
                .WithOne(x => x.Client);


            var seedData = SeedData.ClientsAndProjectsSeedData.GetClients()
                .Select(x => new
                {
                    x.Id,
                    x.Name,
                    x.Url
                });

            builder.HasData(seedData);
        }
    }
}