using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class UserManager : IUserService
    {
        private readonly IUserDal _userDal;

        public UserManager(IUserDal userDal)
        {
            _userDal = userDal;
        }

        public async Task TUserStatusApprovedAsync(int id)
        {
            await _userDal.UserStatusApprovedAsync(id);
        }

        public async Task TUserStatusCancelledAsync(int id)
        {
            await _userDal.UserStatusCancelledAsync(id);
        }

        public async Task<List<User>> TGetListAllAsync()
        {
            return await _userDal.GetListAllAsync();
        }

        public async Task TAddAsync(User entity)
        {
            await _userDal.AddAsync(entity);
        }

        public async Task TDeleteAsync(User entity)
        {
            await _userDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _userDal.DeleteAsync(id);
        }

        public async Task<User> TGetAsync(Expression<Func<User, bool>> predicate)
        {
            return await _userDal.GetAsync(predicate);
        }

        public async Task<IQueryable<User>> TGetAllAsync(Expression<Func<User, bool>> predicate = null)
        {
            return await _userDal.GetAllAsync(predicate);
        }

        public async Task<User> TGetByIdAsync(int id)
        {
            return await _userDal.GetByIdAsync(id);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _userDal.ToggleStatusAsync(id);
        }

        public async Task<IQueryable<User>> TGetListByStatusTrueAsync(Expression<Func<User, bool>> predicate = null)
        {
            return await _userDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task<List<GetUserWithRoleDto>> TGetUserWithRoleAsync()
        {
            return await _userDal.GetUserWithRoleAsync();
        }

        public async Task THardDeleteAsync(int id)
        {
            await _userDal.HardDeleteAsync(id);
        }

        public async Task<User> TGetByEmailAsync(string email)
        {
            return await _userDal.GetByEmailAsync(email);
        }

        public async Task<User> TGetByEmailAndPasswordAsync(string email, string hashedPassword)
        {
            return await _userDal.GetByEmailAndPasswordAsync(email, hashedPassword);
        }

        public async Task<User> TGetByEmailAndCodeAsync(string email, int code)
        {
            return await _userDal.GetByEmailAndCodeAsync(email, code);
        }

        public async Task TUpdateAsync(User entity)
        {
            await _userDal.UpdateAsync(entity);
        }
    }
}
