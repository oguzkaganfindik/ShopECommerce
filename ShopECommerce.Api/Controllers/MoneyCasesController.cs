using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MoneyCasesController : ControllerBase
    {
        private readonly IMoneyCaseService _moneyCaseService;

        public MoneyCasesController(IMoneyCaseService moneyCaseService)
        {
            _moneyCaseService = moneyCaseService;
        }

        [HttpGet]
        public async Task<IActionResult> TotalMoneyCaseAmount()
        {
            var amount = await _moneyCaseService.TTotalMoneyCaseAmountAsync();
            return Ok(amount);
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _moneyCaseService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_moneyCaseService.TGetListByStatusTrue());
        }
    }
}
