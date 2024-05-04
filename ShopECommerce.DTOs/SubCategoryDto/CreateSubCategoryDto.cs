namespace ShopECommerce.DTOs.SubCategoryDto
{
    public class CreateSubCategoryDto
    {
        public string SubCategoryName { get; set; }
        public int CategoryId { get; set; }
        public bool Status { get; set; }
    }
}
