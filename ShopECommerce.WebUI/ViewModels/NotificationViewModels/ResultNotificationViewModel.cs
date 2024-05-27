namespace ShopECommerce.WebUI.ViewModels.NotificationViewModels
{
    public class ResultNotificationViewModel
    {
        public int Id { get; set; }
        public string Type { get; set; }
        public string Icon { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
    }
}
