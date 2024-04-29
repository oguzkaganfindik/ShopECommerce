using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class UserConfiguration : BaseConfiguration<UserEntity>
    {
        public override void Configure(EntityTypeBuilder<UserEntity> builder)
        {
            builder.Property(x => x.Email)
                .HasMaxLength(50);

            builder.Property(x => x.FirstName)
                .HasMaxLength(25);

            builder.Property(x => x.LastName)
                .HasMaxLength(25);

            base.Configure(builder);
        }
    }
}
