using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.RoleDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class RoleController : ControllerBase
    {
        private readonly IRoleService _roleService;
        private readonly IMapper _mapper;

        public RoleController(IRoleService roleService, IMapper mapper)
        {
            _roleService = roleService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult RoleList()
        {
            var value = _mapper.Map<List<ResultRoleDto>>(_roleService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateRole(CreateRoleDto createRoleDto)
        {
            _roleService.TAdd(new Role()
            {
                Name = createRoleDto.Name
            });

            return Ok("Role Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteRole(int id)
        {
            var value = _roleService.TGetById(id);
            _roleService.TDelete(value);
            return Ok("Role Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetRole(int id)
        {
            var value = _roleService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateRole(UpdateRoleDto updateRoleDto)
        {
            _roleService.TUpdate(new Role()
            {
                Id = updateRoleDto.Id,
                Name = updateRoleDto.Name
            });

            return Ok("Role Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _roleService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultRoleDto>>(_roleService.TGetListByStatusTrue());
            return Ok(value);
        }
    }
}
