using AutoMapper;
using ShopECommerce.DTOs.FactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class FactMapping : Profile
    {
        public FactMapping()
        {
            CreateMap<Fact, ResultFactDto>().ReverseMap();
            CreateMap<Fact, CreateFactDto>().ReverseMap();
            CreateMap<Fact, GetFactDto>().ReverseMap();
            CreateMap<Fact, UpdateFactDto>().ReverseMap();
        }
    }
}
