using ShopECommerce.Business.Abstract;
using ShopECommerce.Data.Abstract;
using ShopECommerce.DTOs.RoleDto;
using ShopECommerce.Entities.Concrete;
using System.Linq.Expressions;

namespace ShopECommerce.Business.Concrete
{
    public class RoleManager : IRoleService
    {
        private readonly IRoleDal _roleDal;

        public RoleManager(IRoleDal roleDal)
        {
            _roleDal = roleDal;
        }

        public async Task THardDeleteAsync(int id)
        {
            await _roleDal.HardDeleteAsync(id);
        }

        public async Task TAddAsync(Role entity)
        {
            await _roleDal.AddAsync(entity);
        }
        public async Task TUpdateAsync(Role entity)
        {
            await _roleDal.UpdateAsync(entity);
        }
        public async Task TDeleteAsync(Role entity)
        {
            await _roleDal.DeleteAsync(entity);
        }

        public async Task TDeleteAsync(int id)
        {
            await _roleDal.DeleteAsync(id);
        }

        public async Task<Role> TGetAsync(Expression<Func<Role, bool>> predicate)
        {
            return await _roleDal.GetAsync(predicate);
        }

        public async Task<IQueryable<Role>> TGetAllAsync(Expression<Func<Role, bool>> predicate = null)
        {
            return await _roleDal.GetAllAsync(predicate);
        }

        public async Task<Role> TGetByIdAsync(int id)
        {
            return await _roleDal.GetByIdAsync(id);
        }

        public async Task<List<Role>> TGetListAllAsync()
        {
            return await _roleDal.GetListAllAsync();
        }

        public async Task<IQueryable<Role>> TGetListByStatusTrueAsync(Expression<Func<Role, bool>> predicate = null)
        {
            return await _roleDal.GetListByStatusTrueAsync(predicate);
        }

        public async Task TToggleStatusAsync(int id)
        {
            await _roleDal.ToggleStatusAsync(id);
        }
      
        public async Task TUpdateAsync(UpdateRoleDto updateRoleDto)
        {
            var role = await _roleDal.GetByIdAsync(updateRoleDto.Id);
            if (role == null)
            {
                throw new ArgumentException("Varlık bulunamadı");
            }

            role.Name = updateRoleDto.Name;
            role.Status = updateRoleDto.Status;

            await _roleDal.UpdateAsync(role);
        }

        public async Task TAddAsync(CreateRoleDto createRoleDto)
        {
            await _roleDal.AddAsync(new Role()
            {
                Name = createRoleDto.Name,
                Status = createRoleDto.Status
            });
        }
    }
}
