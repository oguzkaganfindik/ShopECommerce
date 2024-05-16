using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Data.Concrete
{
    public class EfUserDal : GenericRepository<User>, IUserDal
    {
        private readonly ShopECommerceContext _context;
        public EfUserDal(ShopECommerceContext context) : base(context)
        {
            _context = context;
        }

        public void UserStatusApproved(int id)
        {
            var values = _context.Users.Find(id);
            values.Status = true;
            values.EmailConfirmed = true;
            values.Description = "User Onaylandı";
            _context.SaveChanges();
        }

        public void UserStatusCancelled(int id)
        {
            var values = _context.Users.Find(id);
            values.Status = false;
            values.Description = "User İptal Edildi";
            _context.SaveChanges();
        }

        public List<GetUserWithRoleDto> GetUserWithRole()
        {
            var values = _context.Users.Include(x => x.Role).Select(y => new GetUserWithRoleDto
            {
                RoleName = y.Role.Name,
                Id = y.Id,
                RoleId = y.RoleId,
                Username = y.Username,
                Address = y.Address,
                Description = y.Description,
                Email = y.Email,
                FirstName = y.FirstName,
                LastName = y.LastName,
                Password = y.Password,
                Phone = y.Phone,
                Status = y.Status
            }).ToList();

            return values;
        }

        public User GetByEmail(string email)
        {
            return _context.Users.FirstOrDefault(u => u.Email == email);
        }


        public async Task<User> GetByEmailAndPassword(string email, string hashedPassword)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == hashedPassword);
        }

        public async Task<User> GetByEmailAndCode(string email, int code)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.ChangeMailCode == code);
        }

        public async Task UpdateAsync(User entity)
        {
            _context.Update(entity);
            await _context.SaveChangesAsync();
        }
    }
}