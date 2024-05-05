using AutoMapper;
using ShopECommerce.DTOs.FeaturDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class FeaturMapping : Profile
    {
        public FeaturMapping()
        {
            CreateMap<Featur, ResultFeaturDto>().ReverseMap();
            CreateMap<Featur, CreateFeaturDto>().ReverseMap();
            CreateMap<Featur, GetFeaturDto>().ReverseMap();
            CreateMap<Featur, UpdateFeaturDto>().ReverseMap();
        }
    }
}
