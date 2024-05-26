using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.MessageDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MessageController : ControllerBase
    {
        private readonly IMessageService _messageService;
        private readonly IMapper _mapper;

        public MessageController(IMessageService messageService, IMapper mapper)
        {
            _messageService = messageService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> MessageListAsync()
        {
            var value = _mapper.Map<List<ResultMessageDto>>(await _messageService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultMessageDto>>(await _messageService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateMessageAsync(CreateMessageDto createMessageDto)
        {
            await _messageService.TAddAsync(new Message()
            {
                Mail = createMessageDto.Mail,
                MessageContent = createMessageDto.MessageContent,
                MessageSendDate = DateTime.Now,
                NameSurname = createMessageDto.NameSurname,
                Phone = createMessageDto.Phone,
                Status = false,
                Subject = createMessageDto.Subject,
                Description = createMessageDto.Description
            });

            return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessageAsync(int id)
        {
            var value = await _messageService.TGetByIdAsync(id);
            await _messageService.TDeleteAsync(value);
            return Ok("Mesaj Silindi");
        }

        [HttpPut]
        public async Task<IActionResult> UpdateMessageAsync(UpdateMessageDto updateMessageDto)
        {
            await _messageService.TUpdateAsync(new Message()
            {
                Mail = updateMessageDto.Mail,
                MessageContent = updateMessageDto.MessageContent,
                MessageSendDate = updateMessageDto.MessageSendDate,
                NameSurname = updateMessageDto.NameSurname,
                Phone = updateMessageDto.Phone,
                Status = false,
                Subject = updateMessageDto.Subject,
                Description = updateMessageDto.Description,
                Id = updateMessageDto.Id
            });

            return Ok("Mesaj Bilgisi Güncellendi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetMessageAsync(int id)
        {
            var value = await _messageService.TGetByIdAsync(id);
            return Ok(value);
        }


        [HttpGet("MessageStatusApproved/{id}")]
        public async Task<IActionResult> MessageStatusApprovedAsync(int id)
        {
            await _messageService.TMessageStatusApprovedAsync(id);
            return Ok("Message Açıklaması Değiştirildi");
        }

        [HttpGet("MessageStatusCancelled/{id}")]
        public async Task<IActionResult> MessageStatusCancelledAsync(int id)
        {
            await _messageService.TMessageStatusCancelledAsync(id);
            return Ok("Message Açıklaması Değiştirildi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _messageService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }
    }
}

