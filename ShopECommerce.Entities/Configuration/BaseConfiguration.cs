using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Configuration
{
    public abstract class BaseConfiguration<TEntity> : IEntityTypeConfiguration<TEntity>
        where TEntity : BaseEntity
    {
        public virtual void Configure(EntityTypeBuilder<TEntity> builder)
        {
            builder.HasQueryFilter(x => x.IsDeleted == false);

            builder.Property(x => x.ModifiedDate).IsRequired(false);

            builder.Property(x => x.DeletedDate).IsRequired(false);
        }
    }
}
