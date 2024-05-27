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
    public class UsersController : ControllerBase
    {
        private readonly IUserService _userService;
        private readonly IDataProtector _dataProtector;
        private readonly IMapper _mapper;

        public UsersController(IUserService userService, IMapper mapper, IDataProtectionProvider dataProtectionProvider)
        {
            _userService = userService;
            _mapper = mapper;
            _dataProtector = dataProtectionProvider.CreateProtector("security");
        }

        [HttpGet]
        public async Task<IActionResult> UserListAsync()
        {
            var users = await _userService.TGetAllAsync();
            var value = _mapper.Map<List<ResultUserDto>>(users);
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
        public async Task<IActionResult> DeleteUserAsync(int id)
        {
            var value = await _userService.TGetByIdAsync(id);
            if (value == null)
            {
                return NotFound("User not found");
            }
            await _userService.TDeleteAsync(value);
            return Ok("User Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserAsync(int id)
        {
            var value = await _userService.TGetByIdAsync(id);
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
        public async Task<IActionResult> UserStatusApprovedAsync(int id)
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
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _userService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _userService.TGetListByStatusTrueAsync());
        }
    }
}
