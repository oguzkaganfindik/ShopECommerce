using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class ShopTableConfiguration : BaseConfiguration<ShopTable>
    {
        public override void Configure(EntityTypeBuilder<ShopTable> builder)
        {            
            builder.HasOne(st => st.Order)
               .WithOne(o => o.ShopTable)
               .HasForeignKey<Order>(o => o.ShopTableId);

            base.Configure(builder);
        }
    }
}
