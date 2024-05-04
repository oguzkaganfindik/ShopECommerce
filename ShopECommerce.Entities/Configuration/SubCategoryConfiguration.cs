using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class SubCategoryConfiguration : BaseConfiguration<SubCategory>
    {
        public override void Configure(EntityTypeBuilder<SubCategory> builder)
        {

            builder.Property(s => s.SubCategoryName)
                   .IsRequired()
                   .HasMaxLength(100);

            builder.HasOne(s => s.Category)        
                   .WithMany(c => c.SubCategories)  
                   .HasForeignKey(s => s.CategoryId);

            base.Configure(builder);
        }
    }
}
