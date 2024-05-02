using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.BookingDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BookingController : ControllerBase
    {
        private readonly IBookingService _bookingService;
        private readonly IMapper _mapper;

        public BookingController(IBookingService bookingService, IMapper mapper)
        {
            _bookingService = bookingService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult BookingList()
        {
            var value = _mapper.Map<List<ResultBookingDto>>(_bookingService.TGetAll());
            return Ok(value);
        }

        [HttpPost]
        public IActionResult CreateBooking(CreateBookingDto createBookingDto)
        {
            _bookingService.TAdd(new Booking()
            {
                Name = createBookingDto.Name,
                Mail = createBookingDto.Mail,
                Phone = createBookingDto.Phone,
                Date = createBookingDto.Date,
                PersonCount = createBookingDto.PersonCount,
                Description = createBookingDto.Description
            });

            return Ok("Rezervasyon Yapıldı");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            _bookingService.TDelete(value);
            return Ok("Rezervasyon Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetBooking(int id)
        {
            var value = _bookingService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateBooking(UpdateBookingDto updateBookingDto)
        {
            _bookingService.TUpdate(new Booking()
            {
                Id = updateBookingDto.Id,
                Name = updateBookingDto.Name,
                Mail = updateBookingDto.Mail,
                Phone = updateBookingDto.Phone,
                Date = updateBookingDto.Date,
                PersonCount = updateBookingDto.PersonCount,
                Description = updateBookingDto.Description
            });

            return Ok("Rezervasyon Güncellendi");
        }

        [HttpGet("BookingStatusApproved/{id}")]
        public IActionResult BookingStatusApproved(int id)
        {
            _bookingService.BookingStatusApproved(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }

        [HttpGet("BookingStatusCancelled/{id}")]
        public IActionResult BookingStatusCancelled(int id)
        {
            _bookingService.BookingStatusCancelled(id);
            return Ok("Rezervasyon Açıklaması Değiştirildi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _bookingService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_bookingService.TGetListByStatusTrue());
        }
    }
}
