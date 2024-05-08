using AutoMapper;
using ShopECommerce.DTOs.ShopTableDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class ShopTableMapping : Profile
    {
        public ShopTableMapping()
        {
            CreateMap<ShopTable, ResultShopTableDto>().ReverseMap();
            CreateMap<ShopTable, CreateShopTableDto>().ReverseMap();
            CreateMap<ShopTable, UpdateShopTableDto>().ReverseMap();
        }
    }
}
