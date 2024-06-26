﻿using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.AboutDto;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AboutsController : ControllerBase
    {
        private readonly IAboutService _aboutService;
        private readonly IMapper _mapper;

        public AboutsController(IAboutService aboutService, IMapper mapper)
        {
            _aboutService = aboutService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> AboutListAsync()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(await _aboutService.TGetAllAsync());
            return Ok(value);
        }

        [HttpPost]
        public async Task<IActionResult> CreateAboutAsync(CreateAboutDto createAboutDto)
        {
            await _aboutService.TAddAsync(createAboutDto);
            return Ok("Hakkımda Alanı Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteAboutAsync(int id)
        {
            var value = await _aboutService.TGetByIdAsync(id);
            await _aboutService.TDeleteAsync(value);
            return Ok("Hakkımda Alanı Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetAboutAsync(int id)
        {
            var value = await _aboutService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateAboutAsync(UpdateAboutDto updateAboutDto)
        {
            await _aboutService.TUpdateAsync(updateAboutDto);
            return Ok("Hakkımda Alanı Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _aboutService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            var value = _mapper.Map<List<ResultAboutDto>>(await _aboutService.TGetListByStatusTrueAsync());
            return Ok(value);
        }
    }
}
