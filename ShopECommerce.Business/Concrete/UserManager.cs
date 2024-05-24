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

        public List<User> TGetListAll()
        {
            return _userDal.GetListAll();
        }

        public void TAdd(User entity)
        {
            _userDal.Add(entity);
        }

        public void TDelete(User entity)
        {
            _userDal.Delete(entity);
        }

        public void TDelete(int id)
        {
            _userDal.Delete(id);
        }

        public User TGet(Expression<Func<User, bool>> predicate)
        {
            return _userDal.Get(predicate);
        }

        public IQueryable<User> TGetAll(Expression<Func<User, bool>> predicate = null)
        {
            return _userDal.GetAll(predicate);
        }

        public User TGetById(int id)
        {
            return _userDal.GetById(id);
        }
        
        public void TUpdate(User entity)
        {
            _userDal.Update(entity);
        }

        public void TToggleStatus(int id)
        {
            _userDal.ToggleStatus(id);
        }

        public IQueryable<User> TGetListByStatusTrue(Expression<Func<User, bool>> predicate = null)
        {
            return _userDal.GetListByStatusTrue(predicate);
        }

        public async Task<List<GetUserWithRoleDto>> TGetUserWithRoleAsync()
        {
            return await _userDal.GetUserWithRoleAsync();
        }

        public void THardDelete(int id)
        {
            _userDal.HardDelete(id);
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
