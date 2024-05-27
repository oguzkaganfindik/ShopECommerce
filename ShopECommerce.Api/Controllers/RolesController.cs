using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.RoleDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RolesController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RolesController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> RoleListAsync()
        {
            var value = _mapper.Map<List<ResultRoleDto>>(await _roleService.TGetAllAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateRoleAsync(CreateRoleDto createRoleDto)
        {
            await _roleService.TAddAsync(new Role()
            {
                Name = createRoleDto.Name
            });

            return Ok("Role Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteRoleAsync(int id)
        {
            var value = await _roleService.TGetByIdAsync(id);
            await _roleService.TDeleteAsync(value);
            return Ok("Role Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetRoleAsync(int id)
        {
            var value = await _roleService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateRoleAsync(UpdateRoleDto updateRoleDto)
        {
            await _roleService.TUpdateAsync(new Role()
            {
                Id = updateRoleDto.Id,
                Name = updateRoleDto.Name
            });

            return Ok("Role Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _roleService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultRoleDto>>(await _roleService.TGetListByStatusTrueAsync());
            return Ok(value);
        }
    }
}
