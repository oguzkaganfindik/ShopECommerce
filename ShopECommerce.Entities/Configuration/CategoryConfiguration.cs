using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {

            builder.Property(x => x.CategoryName)
                .HasMaxLength(40);

            base.Configure(builder);
        }
    }
}
