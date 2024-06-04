using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        Task TUpdateAsync(UpdateUserDto updateUserDto);
        Task TUpdateAsync(User entity);
        Task TUserStatusApprovedAsync(int id);
        Task TUserStatusCancelledAsync(int id);
        Task<List<GetUserWithRoleDto>> TGetUserWithRoleAsync();
        Task<User> TGetByEmailAsync(string email);
        Task<User> TGetByEmailAndPasswordAsync(string email, string hashedPassword);
        Task<User> TGetByEmailAndCodeAsync(string email, int code);
    }
}
