using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Configuration
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T>
        where T : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.ModifiedDate).IsRequired(false);

            builder.Property(x => x.DeletedDate).IsRequired(false);
        }
    }
}
