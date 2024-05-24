using AutoMapper;
using ShopECommerce.DTOs.BasketItemDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class BasketItemMapping : Profile
    {
        public BasketItemMapping()
        {
            CreateMap<BasketItem, ResultBasketItemDto>().ReverseMap();
            CreateMap<BasketItem, CreateBasketItemDto>().ReverseMap();
            CreateMap<BasketItem, UpdateBasketItemDto>().ReverseMap();
        }
    }
}
