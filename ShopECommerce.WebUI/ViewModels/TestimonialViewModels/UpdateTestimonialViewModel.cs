namespace ShopECommerce.WebUI.ViewModels.TestimonialViewModels
{
    public class UpdateTestimonialViewModel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Title { get; set; }
        public string Comment { get; set; }
        public string ImagePath { get; set; }
        public bool Status { get; set; }
        public IFormFile? File { get; set; }
    }
}