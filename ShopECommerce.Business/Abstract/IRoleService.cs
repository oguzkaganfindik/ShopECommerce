using ShopECommerce.DTOs.RoleDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Business.Abstract
{
    public interface IRoleService : IGenericService<Role>
    {
        Task TUpdateAsync(UpdateRoleDto updateRoleDto);
        Task TAddAsync(CreateRoleDto createRoleDto);
    }
}
