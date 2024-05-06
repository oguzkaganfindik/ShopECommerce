using AutoMapper;
using ShopECommerce.DTOs.BannerDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, CreateBannerDto>().ReverseMap();
            CreateMap<Banner, GetBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
        }
    }
}
