using AutoMapper;
using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Mapping
{
    public class UserMapping : Profile
    {
        public UserMapping()
        {
            CreateMap<User, ResultUserDto>().ReverseMap();
            CreateMap<User, CreateUserDto>().ReverseMap();
            CreateMap<User, GetUserDto>().ReverseMap();
            CreateMap<User, UpdateUserDto>().ReverseMap();
        }
    }
}
