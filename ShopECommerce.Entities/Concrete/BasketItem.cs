﻿using ShopECommerce.Entities.Abstract;

namespace ShopECommerce.Entities.Concrete
{
    public class BasketItem : BaseEntity
    {
        public string BasketItemCustomerMail { get; set; }
        public int OrderId { get; set; }
        public Order Order { get; set; }
        public List<Basket> Baskets { get; set; }
    }
}
