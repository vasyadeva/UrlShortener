using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using UrlShortener.Data.Entities;

namespace UrlShortener.Configurations.Entities
{
    public class DescriptionSeedConfiguration : IEntityTypeConfiguration<Description>
    {
        public void Configure(EntityTypeBuilder<Description> builder)
        {
            builder.HasData(
                new Description
                {
                    Id = 1,
                   Text = "Some Text"
                });
        }
    }
}
