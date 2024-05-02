using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.MessageDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessagesController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessagesController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult MessageList()
        {
            var value = _mapper.Map<List<ResultMessageDto>>(_messageService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateMessage(CreateMessageDto createMessageDto)
        {
            _messageService.TAdd(new Message()
            {
                Mail = createMessageDto.Mail,
                MessageContent = createMessageDto.MessageContent,
                MessageSendDate = DateTime.Now,
                NameSurname = createMessageDto.NameSurname,
                Phone = createMessageDto.Phone,
                Status = false,
                Subject = createMessageDto.Subject,
            });

            return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMessage(int id)
        {
            var value = _messageService.TGetById(id);
            _messageService.TDelete(value);
            return Ok("Mesaj Silindi");
        }

        [HttpPut]
        public IActionResult UpdateMessage(UpdateMessageDto updateMessageDto)
        {
            _messageService.TUpdate(new Message()
            {
                Mail = updateMessageDto.Mail,
                MessageContent = updateMessageDto.MessageContent,
                MessageSendDate = updateMessageDto.MessageSendDate,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                Status = false,
                Subject = updateMessageDto.Subject,
                Id = updateMessageDto.Id
            });

            return Ok("Mesaj Bilgisi Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetMessage(int id)
        {
            var value = _messageService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _messageService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_messageService.TGetListByStatusTrue());
        }
    }
}

