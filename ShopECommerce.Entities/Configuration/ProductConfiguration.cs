using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(50);

            builder.Property(x => x.Description)
                .HasMaxLength(200)
                .IsRequired(false);

            builder.Property(x => x.Price)
                .IsRequired(false);

            builder.Property(x => x.ImageUrl)
                .IsRequired(false);

            base.Configure(builder);
        }
    }
}
