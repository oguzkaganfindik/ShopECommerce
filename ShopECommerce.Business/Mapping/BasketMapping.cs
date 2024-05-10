using AutoMapper;
using ShopECommerce.DTOs.BasketDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class BasketMapping : Profile
    {
        public BasketMapping()
        {
            CreateMap<Basket, CreateBasketDto>().ReverseMap();
            CreateMap<Basket, ResultBasketListWithProductsDto>().ReverseMap();
            CreateMap<Basket, ResultBasketDto>().ReverseMap();
        }
    }
}
