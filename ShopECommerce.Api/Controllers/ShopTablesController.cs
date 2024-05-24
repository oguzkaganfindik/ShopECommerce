using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.ShopTableDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ShopTablesController : ControllerBase
    {
        private readonly IShopTableService _shopTableService;
        public ShopTablesController(IShopTableService shopTableService)
        {
            _shopTableService = shopTableService;
        }

        [HttpGet("ShopTableCount")]
        public async Task<IActionResult> ShopTableCountAsync()
        {
            return Ok(await _shopTableService.TShopTableCountAsync());
        }

        [HttpGet]
        public IActionResult ShopTableList()
        {
            var values = _shopTableService.TGetAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateShopTable(CreateShopTableDto createShopTableDto)
        {
            ShopTable shopTable = new ShopTable()
            {
                Name = createShopTableDto.Name,
                Status = false
            };

            _shopTableService.TAdd(shopTable);
            return Ok("Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteShopTable(int id)
        {
            var value = _shopTableService.TGetById(id);
            _shopTableService.TDelete(value);
            return Ok("Silindi");
        }

        [HttpPut]
        public IActionResult UpdateShopTable(UpdateShopTableDto updateShopTableDto)
        {
            ShopTable shopTable = new ShopTable()
            {
                Name = updateShopTableDto.Name,
                Status = false,
                Id = updateShopTableDto.Id
            };

            _shopTableService.TUpdate(shopTable);
            return Ok("Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetShopTable(int id)
        {
            var value = _shopTableService.TGetById(id);
            return Ok(value);
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _shopTableService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_shopTableService.TGetListByStatusTrue());
        }
    }
}
