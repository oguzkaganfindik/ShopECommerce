using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.ContactDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactsController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactsController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> ContactListAsync()
        {
            var value = _mapper.Map<List<ResultContactDto>>(await _contactService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultContactDto>>(await _contactService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateContactAsync(CreateContactDto createContactDto)
        {
            await _contactService.TAddAsync(createContactDto);
            return Ok("İletişim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteContactAsync(int id)
        {
            var value = await _contactService.TGetByIdAsync(id);
            await _contactService.TDeleteAsync(value);
            return Ok("İletişim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetContactAsync(int id)
        {
            var value = await _contactService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateContactAsync(UpdateContactDto updateContactDto)
        {
            await _contactService.TUpdateAsync(updateContactDto);
            return Ok("İletişim Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _contactService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }      
    }
}
