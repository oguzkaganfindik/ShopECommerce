using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IUserService : IGenericService<User>
    {
        void UserStatusApproved(int id);
        void UserStatusCancelled(int id);
        List<GetUserWithRoleDto> TGetUserWithRole();
    }
}
