namespace ShopECommerce.DTOs.BannerDto
{
    public class CreateBannerDto
    {
        public string Title { get; set; }
        public string SubTitle { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public string UrlLabel { get; set; }
        public string ImagePath { get; set; }
        public string Price1 { get; set; }
        public string Price2 { get; set; }
        public bool Status { get; set; }
    }
}
