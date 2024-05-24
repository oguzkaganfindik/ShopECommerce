using AutoMapper;
using Microsoft.AspNetCore.DataProtection;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.UserDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper, IDataProtectionProvider dataProtectionProvider)
        {
            _userService = userService;
            _mapper = mapper;
            _dataProtector = dataProtectionProvider.CreateProtector("security");
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var value = _mapper.Map<List<ResultUserDto>>(_userService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetUserWithRole")]
        public async Task<IActionResult> GetUserWithRoleAsync()
        {
            var values = await _userService.TGetUserWithRoleAsync();
            var result = _mapper.Map<List<GetUserWithRoleDto>>(values);
            return Ok(result);
        }


        [HttpDelete("{id}")]
        public IActionResult DeleteUser(int id)
        {
            var value = _userService.TGetById(id);
            _userService.TDelete(value);
            return Ok("User Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetUser(int id)
        {
            var value = _userService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateUserAsync(UpdateUserDto updateUserDto)
        {
            await _userService.TUpdateAsync(new User()
            {
                Id = updateUserDto.Id,
                Email = updateUserDto.Email,
                Password = _dataProtector.Protect(updateUserDto.Password),
                FirstName = updateUserDto.FirstName,
                LastName = updateUserDto.LastName,
                Username = updateUserDto.Username,
                Address = updateUserDto.Address,
                Phone = updateUserDto.Phone,
                RoleId = updateUserDto.RoleId,
                Description = updateUserDto.Description
            });

            return Ok("User Güncellendi");
        }

        [HttpGet("UserStatusApproved/{id}")]
        public async Task<IActionResult> UserStatusApproved(int id)
        {
            await _userService.TUserStatusApprovedAsync(id);
            return Ok("User Açıklaması Değiştirildi");
        }

        [HttpGet("UserStatusCancelled/{id}")]
        public async Task<IActionResult> UserStatusCancelledAsync(int id)
        {
            await _userService.TUserStatusCancelledAsync(id);
            return Ok("User Açıklaması Değiştirildi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _userService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_userService.TGetListByStatusTrue());
        }
    }
}
