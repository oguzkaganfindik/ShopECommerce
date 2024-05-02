using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class ProductConfiguration : BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.Property(x => x.ProductName)
                .HasMaxLength(50);

            base.Configure(builder);
        }
    }
}
