﻿using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.MenuTableDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class MenuTablesController : ControllerBase
    {
        private readonly IMenuTableService _menuTableService;
        public MenuTablesController(IMenuTableService menuTableService)
        {
            _menuTableService = menuTableService;
        }

        [HttpGet("MenuTableCount")]
        public IActionResult MenuTableCount()
        {
            return Ok(_menuTableService.TMenuTableCount());
        }

        [HttpGet]
        public IActionResult MenuTableList()
        {
            var values = _menuTableService.TGetListAll();
            return Ok(values);
        }

        [HttpPost]
        public IActionResult CreateMenuTable(CreateMenuTableDto createMenuTableDto)
        {
            MenuTable menuTable = new MenuTable()
            {
                Name = createMenuTableDto.Name,
                Status = false
            };

            _menuTableService.TAdd(menuTable);
            return Ok("Masa Başarılı Bir Şekilde Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);
            _menuTableService.TDelete(value);
            return Ok("Masa Silindi");
        }

        [HttpPut]
        public IActionResult UpdateMenuTable(UpdateMenuTableDto updateMenuTableDto)
        {
            MenuTable menuTable = new MenuTable()
            {
                Name = updateMenuTableDto.Name,
                Status = false,
                Id = updateMenuTableDto.Id
            };

            _menuTableService.TUpdate(menuTable);
            return Ok("Masa Bilgisi Güncellendi");
        }

        [HttpGet("{id}")]
        public IActionResult GetMenuTable(int id)
        {
            var value = _menuTableService.TGetById(id);
            return Ok(value);
        }
    }
}
