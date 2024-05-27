namespace ShopECommerce.WebUI.ViewModels.NotificationViewModels
{
    public class UpdateNotificationViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public bool Status { get; set; }
    }
}
