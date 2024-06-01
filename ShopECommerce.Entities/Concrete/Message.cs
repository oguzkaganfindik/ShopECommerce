using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class Message : BaseEntity
    {
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public string Description { get; set; }
        public int? NotificationId { get; set; }
        public Notification Notification { get; set; }
    }
}
