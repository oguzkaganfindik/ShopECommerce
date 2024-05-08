using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class RoleConfiguration : BaseConfiguration<Role>
    {
        public override void Configure(EntityTypeBuilder<Role> builder)
        {
            builder.Property(x => x.Name)
                .HasMaxLength(25);

            builder.HasMany(r => r.Users)         
                   .WithOne(u => u.Role)          
                   .HasForeignKey(u => u.RoleId) 
                   .OnDelete(DeleteBehavior.Cascade);

            base.Configure(builder);
        }
    }
}
