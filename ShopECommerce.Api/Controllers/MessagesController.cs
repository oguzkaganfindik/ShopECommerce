using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.MessageDto;

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
            await _messageService.TAddAsync(createMessageDto);
            return Ok("Mesaj Başarılı Bir Şekilde Gönderildi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteMessageAsync(int id)
        {
            await _messageService.TDeleteMessageAndNotificationAsync(id);
            return Ok("Mesaj Silindi");
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
            return Ok("Mesaj Okundu");
        }

        [HttpGet("MessageStatusCancelled/{id}")]
        public async Task<IActionResult> MessageStatusCancelledAsync(int id)
        {
            await _messageService.TMessageStatusCancelledAsync(id);
            return Ok("Mesaj Kapatıldı");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _messageService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }
    }
}

