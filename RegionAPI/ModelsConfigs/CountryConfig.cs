using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RegionAPI.Models;

namespace RegionAPI.ModelsConfigs
{
    public class CountryConfig : IEntityTypeConfiguration<CountryModel>
    {
        public void Configure(EntityTypeBuilder<CountryModel> builder)
        {
            builder.HasKey(b => b.Id).HasName("CountryId");
            builder.Property(b => b.Name).HasMaxLength(500).HasDefaultValue("Country").IsRequired();
            builder.Property(b => b.Motto).HasMaxLength(500);
            builder.Property(b => b.Anthem).HasMaxLength(500);
            builder.Property(b => b.Capital).HasMaxLength(500);
        }
    }
}
