using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class UserConfiguration : BaseConfiguration<User>
    {
        public override void Configure(EntityTypeBuilder<User> builder)
        {
            builder.Property(x => x.Email)
                .HasMaxLength(50);

            builder.Property(x => x.FirstName)
                .HasMaxLength(50);

            builder.Property(x => x.LastName)
                .HasMaxLength(50);

            builder.HasOne(u => u.Role)           
                   .WithMany(r => r.Users)       
                   .HasForeignKey(u => u.RoleId) 
                   .OnDelete(DeleteBehavior.Restrict); 

            base.Configure(builder);
        }
    }
}
