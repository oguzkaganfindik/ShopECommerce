namespace ShopECommerce.WebUI.ViewModels.UserViewModels
{
    public class GetUserViewModel
    {
        public int Id { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Username { get; set; }
        public string? Address { get; set; }
        public string? Phone { get; set; }
        public int RoleId { get; set; }
        public string Description { get; set; }
        public bool Status { get; set; }
    }
}
