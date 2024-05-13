using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        void UserStatusApproved(int id);
        void UserStatusCancelled(int id);
        public List<GetUserWithRoleDto> GetUserWithRole();
        User GetByEmail(string email);
        Task<User> GetByEmailAndPassword(string email, string hashedPassword);
        Task<User> GetByEmailAndCode(string email, int code);
        Task UpdateAsync(User entity);
    }
}
