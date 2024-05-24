using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class BasketItemConfiguration : BaseConfiguration<BasketItem>
    {
        public override void Configure(EntityTypeBuilder<BasketItem> builder)
        {            
            builder.HasOne(st => st.Order)
               .WithOne(o => o.BasketItem)
               .HasForeignKey<Order>(o => o.BasketItemId);

            base.Configure(builder);
        }
    }
}
