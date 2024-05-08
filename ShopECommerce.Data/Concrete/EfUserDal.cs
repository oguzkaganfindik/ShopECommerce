using Microsoft.EntityFrameworkCore;
using ShopECommerce.Data.Abstract;
using ShopECommerce.Data.Context;
using ShopECommerce.Data.Repositories;
using ShopECommerce.DTOs.SubCategoryDto;
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
            values.Description = "User Onaylandı";
            _context.SaveChanges();
        }

        public void UserStatusCancelled(int id)
        {
            var values = _context.Users.Find(id);
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
    }
}