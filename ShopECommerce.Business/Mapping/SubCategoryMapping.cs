using AutoMapper;
using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class SubCategoryMapping : Profile
    {
        public SubCategoryMapping()
        {
            CreateMap<SubCategory, ResultSubCategoryDto>().ReverseMap();
            CreateMap<SubCategory, CreateSubCategoryDto>().ReverseMap();
            CreateMap<SubCategory, GetSubCategoryDto>().ReverseMap();
            CreateMap<SubCategory, UpdateSubCategoryDto>().ReverseMap();
        }
    }
}
