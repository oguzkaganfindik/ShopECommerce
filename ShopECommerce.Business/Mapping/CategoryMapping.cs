using AutoMapper;
using ShopECommerce.DTOs.CategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {
            CreateMap<Category, ResultSubCategoryDto>().ReverseMap();
            CreateMap<Category, CreateSubCategoryDto>().ReverseMap();
            CreateMap<Category, GetSubCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateSubCategoryDto>().ReverseMap();
        }
    }
}
