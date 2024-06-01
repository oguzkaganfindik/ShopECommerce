using Microsoft.EntityFrameworkCore.Metadata.Builders;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Entities.Configuration
{
    public class MessageConfiguration : BaseConfiguration<Message>
    {
        public override void Configure(EntityTypeBuilder<Message> builder)
        {
            builder.HasOne(m => m.Notification)
                   .WithMany(n => n.Messages)
                   .HasForeignKey(m => m.NotificationId)
                   .IsRequired(false);

            base.Configure(builder);
        }
    }
}
