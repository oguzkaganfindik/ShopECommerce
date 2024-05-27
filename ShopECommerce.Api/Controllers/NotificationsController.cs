using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.NotificationDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationsController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationsController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public async Task<ActionResult> NotificationListAsync()
        {
            return Ok(await _notificationService.TGetAllAsync());
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
            Notification notification = new Notification()
            {
                Description = createNotificationDto.Description,
                Icon = createNotificationDto.Icon,
                Status = createNotificationDto.Status,
                Type = createNotificationDto.Type,
                CreatedDate = createNotificationDto.CreatedDate
            };

            await _notificationService.TAddAsync(notification);

            return Ok("Ekleme İşlemi Başarıyla Yapıldı");
        }

        [HttpDelete("{id}")]
        public async Task<ActionResult> DeleteNotificationAsync(int id)
        {
            await _notificationService.THardDeleteAsync(id);
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
            Notification notification = new Notification()
            {
                Id = updateNotificationDto.Id,
                Description = updateNotificationDto.Description,
                Icon = updateNotificationDto.Icon,
                Status = updateNotificationDto.Status,
                Type = updateNotificationDto.Type,
                ModifiedDate = updateNotificationDto.ModifiedDate
            };

            await _notificationService.TUpdateAsync(notification);

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

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _notificationService.TGetListByStatusTrueAsync());
        }
    }
}