using ShopECommerce.Data.Concrete;
using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Abstract
{
    public interface IUserDal : IGenericDal<User>
    {
        void UserStatusApproved(int id);
        void UserStatusCancelled(int id);
        public List<GetUserWithRoleDto> GetUserWithRole();
    }
}
