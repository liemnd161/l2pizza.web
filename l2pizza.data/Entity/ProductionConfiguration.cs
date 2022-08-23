using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore;

namespace l2pizza.data.Entity
{
    public class ProductionConfiguration : IEntityTypeConfiguration<Production>
    {
        public void Configure(EntityTypeBuilder<Production> builder)
        {
            builder.Property(b => b.Name).IsRequired().HasMaxLength(100);
            builder.Property(b => b.Description).IsRequired(false).HasMaxLength(100);
            builder.Property(b => b.Price).IsRequired().HasPrecision(18, 3);
        }
    }
}