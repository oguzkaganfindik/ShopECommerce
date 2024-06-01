using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.NotificationDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;
        private readonly IMapper _mapper;

        public NotificationsController(INotificationService notificationService, IMapper mapper)
        {
            _notificationService = notificationService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<ActionResult> NotificationListAsync()
        {
            var value = _mapper.Map<List<ResultNotificationDto>>(await _notificationService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultNotificationDto>>(await _notificationService.TGetListByStatusTrueAsync());
            return Ok(value);
        }

        [HttpGet("NotificationCountByStatusTrue/{id}")]
        public async Task<ActionResult> NotificationCountByStatusTrueAsync()
        {
            return Ok(await _notificationService.TNotificationCountByStatusFalseAsync());
        }

        [HttpGet("GetAllNotificationsByTrue/{id}")]
        public async Task<ActionResult> GetAllNotificationsByTrueAsync()
        {
            return Ok(await _notificationService.TGetAllNotificationsByTrueAsync());
        }

        [HttpPost]
        public async Task<ActionResult> CreateNotificationAsync(CreateNotificationDto createNotificationDto)
        {
            await _notificationService.TAddAsync(createNotificationDto);
            return Ok("Ekleme İşlemi Başarıyla Yapıldı");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteNotificationAsync(int id)
        {
            var value = await _notificationService.TGetByIdAsync(id);
            await _notificationService.TDeleteAsync(value);
            return Ok("Bildirim Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetNotificationAsync(int id)
        {
            var value = await _notificationService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<ActionResult> UpdateNotificationAsync(UpdateNotificationDto updateNotificationDto)
        {
            await _notificationService.TUpdateAsync(updateNotificationDto);
            return Ok("Güncelleme İşlemi Başarıyla Yapıldı");
        }

        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public async Task<IActionResult> NotificationStatusChangeToFalseAsync(int id)
        {
            await _notificationService.TNotificationStatusChangeToFalseAsync(id);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public async Task<IActionResult> NotificationStatusChangeToTrueAsync(int id)
        {
            await _notificationService.TNotificationStatusChangeToTrueAsync(id);
            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _notificationService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }   
    }
}