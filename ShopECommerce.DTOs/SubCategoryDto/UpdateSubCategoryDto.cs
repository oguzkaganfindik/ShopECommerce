namespace ShopECommerce.DTOs.SubCategoryDto
{
    public class UpdateSubCategoryDto
    {
        public int Id { get; set; }
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
