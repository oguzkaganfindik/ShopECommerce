namespace ShopECommerce.WebUI.ViewModels.SliderViewModels
{
    public class UpdateSliderViewModel
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public string Label1 { get; set; }
        public string ImagePath1 { get; set; }
        public string Url1 { get; set; }
        public string Label2 { get; set; }
        public string ImagePath2 { get; set; }
        public string Url2 { get; set; }
        public bool Status { get; set; }
        public IFormFile? File1 { get; set; }
        public IFormFile? File2 { get; set; }
    }
}
