using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace l2pizza.data.Entity
{
    public class BaseEntityConfiguration : IEntityTypeConfiguration<BaseEntity>
    {
        public void Configure(EntityTypeBuilder<BaseEntity> builder)
        {
            builder.HasKey(x => x.Id);

            builder.Property(b => b.CreatedBy).IsRequired();
            builder.Property(t => t.CreatedAt).IsRequired(false).HasDefaultValueSql("GetUtcDate()");
            builder.Property(b => b.IsDeleted).HasDefaultValue(false);
        }
    }
}