using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.ContactDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ContactController : ControllerBase
    {
        private readonly IContactService _contactService;
        private readonly IMapper _mapper;

        public ContactController(IContactService contactService, IMapper mapper)
        {
            _contactService = contactService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult ContactList()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetAll());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            var value = _mapper.Map<List<ResultContactDto>>(_contactService.TGetListByStatusTrue());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateContact(CreateContactDto createContactDto)
        {
            _contactService.TAdd(new Contact()
            {
                Location = createContactDto.Location,
                Phone = createContactDto.Phone,
                Mail = createContactDto.Mail,
                FooterTitle = createContactDto.FooterTitle,
                FooterDescription = createContactDto.FooterDescription,
                SiteName = createContactDto.SiteName,
                SiteTitle = createContactDto.SiteTitle,
                SiteUrl = createContactDto.SiteUrl,
                GoogleMapsApi = createContactDto.GoogleMapsApi
            });

            return Ok("İletişim Bilgisi Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteContact(int id)
        {
            var value = _contactService.TGetById(id);
            _contactService.TDelete(value);
            return Ok("İletişim Bilgisi Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetContact(int id)
        {
            var value = _contactService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateContact(UpdateContactDto updateContactDto)
        {
            _contactService.TUpdate(new Contact()
            {
                Id = updateContactDto.Id,
                Location = updateContactDto.Location,
                Phone = updateContactDto.Phone,
                Mail = updateContactDto.Mail,
                FooterTitle = updateContactDto.FooterTitle,
                FooterDescription = updateContactDto.FooterDescription,
                SiteName = updateContactDto.SiteName,
                SiteTitle = updateContactDto.SiteTitle,
                SiteUrl = updateContactDto.SiteUrl,
                GoogleMapsApi= updateContactDto.GoogleMapsApi
            });
            return Ok("İletişim Bilgisi Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _contactService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }      
    }
}
