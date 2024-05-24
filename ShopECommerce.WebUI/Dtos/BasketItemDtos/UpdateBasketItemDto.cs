namespace ShopECommerce.WebUI.Dtos.BasketItemDtos
{
    public class UpdateBasketItemDto
    {
        public int Id { get; set; }
        public string BasketItemCustomerMail { get; set; }
        public bool Status { get; set; }
    }
}
