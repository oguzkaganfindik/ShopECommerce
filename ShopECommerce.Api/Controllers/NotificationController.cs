using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.NotificationDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class NotificationController : ControllerBase
    {
        private readonly INotificationService _notificationService;

        public NotificationController(INotificationService notificationService)
        {
            _notificationService = notificationService;
        }

        [HttpGet]
        public ActionResult NotificationList()
        {
            return Ok(_notificationService.TGetAll());
        }

        [HttpGet("NotificationCountByStatusTrue/{id}")]
        public ActionResult NotificationCountByStatusTrue()
        {
            return Ok(_notificationService.TNotificationCountByStatusFalse());
        }

        [HttpGet("GetAllNotificationsByTrue/{id}")]
        public ActionResult GetAllNotificationsByTrue()
        {
            return Ok(_notificationService.TGetAllNotificationsByFalse());
        }

        [HttpPost]
        public ActionResult CreateNotification(CreateNotificationDto createNotificationDto)
        {
            Notification notification = new Notification()
            {
                Description = createNotificationDto.Description,
                Icon = createNotificationDto.Icon,
                Status = createNotificationDto.Status,
                Type = createNotificationDto.Type,
                CreatedDate = createNotificationDto.CreatedDate
            };

            _notificationService.TAdd(notification);

            return Ok("Ekleme İşlemi Başarıyla Yapıldı");
        }

        [HttpDelete("{id}")]
        public ActionResult DeleteNotification(int id)
        {
            _notificationService.THardDelete(id);
            return Ok("Bildirim Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetNotification(int id)
        {
            var value = _notificationService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public ActionResult UpdateNotification(UpdateNotificationDto updateNotificationDto)
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

            _notificationService.TUpdate(notification);

            return Ok("Güncelleme İşlemi Başarıyla Yapıldı");
        }

        [HttpGet("NotificationStatusChangeToFalse/{id}")]
        public IActionResult NotificationStatusChangeToFalse(int id)
        {
            _notificationService.TNotificationStatusChangeToFalse(id);
            return Ok("Güncelleme yapıldı");
        }

        [HttpGet("NotificationStatusChangeToTrue/{id}")]
        public IActionResult NotificationStatusChangeToTrue(int id)
        {
            _notificationService.TNotificationStatusChangeToTrue(id);
            return Ok("Güncelleme Yapıldı");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _notificationService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_notificationService.TGetListByStatusTrue());
        }
    }
}