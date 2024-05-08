using AutoMapper;
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
        private readonly IMapper _mapper;

        public UserController(IUserService userService, IMapper mapper)
        {
            _userService = userService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult UserList()
        {
            var value = _mapper.Map<List<ResultUserDto>>(_userService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetUserWithRole")]
        public IActionResult GetUserWithRole()
        {
            var values = _userService.TGetUserWithRole();
            var result = _mapper.Map<List<GetUserWithRoleDto>>(values);
            return Ok(result);
        }

        [HttpPost]
        public IActionResult CreateUser(CreateUserDto createUserDto)
        {
            createUserDto.Description = "User Kayıt Oldu";
            _userService.TAdd(new User()
            {
                Email = createUserDto.Email,
                Password = createUserDto.Password,
                FirstName = createUserDto.FirstName,
                LastName = createUserDto.LastName,
                Username = createUserDto.Username,
                Address = createUserDto.Address,
                Phone = createUserDto.Phone,
                RoleId = createUserDto.RoleId,
                Description = createUserDto.Description
            });

            return Ok("User Yapıldı");
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
        public IActionResult UpdateUser(UpdateUserDto updateUserDto)
        {
            _userService.TUpdate(new User()
            {
                Id = updateUserDto.Id,
                Email = updateUserDto.Email,
                Password = updateUserDto.Password,
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
        public IActionResult UserStatusApproved(int id)
        {
            _userService.UserStatusApproved(id);
            return Ok("User Açıklaması Değiştirildi");
        }

        [HttpGet("UserStatusCancelled/{id}")]
        public IActionResult UserStatusCancelled(int id)
        {
            _userService.UserStatusCancelled(id);
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
