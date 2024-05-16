namespace ShopECommerce.WebUI.Dtos.NotificationDtos
{
    public class CreateNotificationDto
    {
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
