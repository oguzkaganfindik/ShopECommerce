using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        Task UserStatusApprovedAsync(int id);
        Task UserStatusCancelledAsync(int id);
        Task<List<GetUserWithRoleDto>> GetUserWithRoleAsync();
        Task<User> GetByEmailAsync(string email);
        Task<User> GetByEmailAndPasswordAsync(string email, string hashedPassword);
        Task<User> GetByEmailAndCodeAsync(string email, int code);
        Task UpdateAsync(User entity);
    }
}
