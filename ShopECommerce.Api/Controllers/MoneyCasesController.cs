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
        public async Task<IActionResult> TotalMoneyCaseAmountAsync()
        {
            var amount = await _moneyCaseService.TTotalMoneyCaseAmountAsync();
            return Ok(amount);
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _moneyCaseService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _moneyCaseService.TGetListByStatusTrueAsync());
        }
    }
}
