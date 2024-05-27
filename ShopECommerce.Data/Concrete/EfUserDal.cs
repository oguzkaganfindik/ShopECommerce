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

        public async Task UserStatusApprovedAsync(int id)
        {
            var values = await _context.Users.FindAsync(id);
            if (values != null)
            {
                values.Status = true;
                values.EmailConfirmed = true;
                values.Description = "Onaylandı";
                await _context.SaveChangesAsync();
            }
        }

        public async Task UserStatusCancelledAsync(int id)
        {
            var values = await _context.Users.FindAsync(id);
            if (values != null)
            {
                values.Status = false;
                values.Description = "İptal Edildi";
                await _context.SaveChangesAsync();
            }
        }

        public async Task<List<GetUserWithRoleDto>> GetUserWithRoleAsync()
        {
            var values = await _context.Users.Include(x => x.Role).Select(y => new GetUserWithRoleDto
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
            }).ToListAsync();

            return values;
        }

        public async Task<User> GetByEmailAsync(string email)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email);
        }


        public async Task<User> GetByEmailAndPasswordAsync(string email, string hashedPassword)
        {
            return await _context.Users.FirstOrDefaultAsync(u => u.Email == email && u.Password == hashedPassword);
        }

        public async Task<User> GetByEmailAndCodeAsync(string email, int code)
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