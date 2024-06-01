namespace ShopECommerce.WebUI.ViewModels.MessageViewModels
{
    public class CreateMessageViewModel
    {
        public string NameSurname { get; set; }
        public string Mail { get; set; }
        public string Phone { get; set; }
        public string Subject { get; set; }
        public string MessageContent { get; set; }
        public DateTime CreatedDate { get; set; }
        public string Description { get; set; }
        public int NotificationId { get; set; }
        public bool Status { get; set; }
    }
}
