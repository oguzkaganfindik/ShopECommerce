using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using ShopECommerce.Business.Abstract;
using ShopECommerce.DTOs.SubCategoryDto;
using ShopECommerce.Entities.Concrete;

namespace ShopECommerce.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubCategoryController : ControllerBase
    {
        private readonly ISubCategoryService _subCategoryService;
        private readonly IMapper _mapper;

        public SubCategoryController(ISubCategoryService SubCategoryService, IMapper mapper)
        {
            _subCategoryService = SubCategoryService;
            _mapper = mapper;
        }

        [HttpGet]
        public async Task<IActionResult> SubCategoryListAsync()
        {
            var value = _mapper.Map<List<ResultSubCategoryDto>>(await _subCategoryService.TGetAllAsync());
            return Ok(value);
        }

        [HttpGet("GetSubCategoriesWithCategories")]
        public async Task<IActionResult> GetSubCategoriesWithCategoriesAsync()
        {
            var values = await _subCategoryService.TGetSubCategoriesWithCategoriesAsync();
            var result = _mapper.Map<List<ResultSubCategoryWithCategory>>(values);
            return Ok(result);
        }

        [HttpGet("SubCategoryCount")]
        public async Task<IActionResult> SubCategoryCountAsync()
        {
            var count = await _subCategoryService.TSubCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("ActiveSubCategoryCount")]
        public async Task<IActionResult> ActiveSubCategoryCountAsync()
        {
            var count = await _subCategoryService.TActiveSubCategoryCountAsync();
            return Ok(count);
        }


        [HttpGet("PassiveSubCategoryCount")]
        public async Task<IActionResult> PassiveSubCategoryCountAsync()
        {
            var count = await _subCategoryService.TPassiveSubCategoryCountAsync();
            return Ok(count);
        }

        [HttpPost]
        public async Task<IActionResult> CreateSubCategoryAsync(CreateSubCategoryDto createSubCategoryDto)
        {
            await _subCategoryService.TAddAsync(new SubCategory()
            {
                SubCategoryName = createSubCategoryDto.SubCategoryName,
                CategoryId = createSubCategoryDto.CategoryId,
            });

            return Ok("SubCategory Eklendi");
        }

        [HttpDelete("{id}")]
        public async Task<IActionResult> DeleteSubCategoryAsync(int id)
        {
            var value = await _subCategoryService.TGetByIdAsync(id);
            await _subCategoryService.TDeleteAsync(value);
            return Ok("SubCategory Silindi");
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetSubCategoryAsync(int id)
        {
            var value = await _subCategoryService.TGetByIdAsync(id);
            return Ok(value);
        }

        [HttpPut]
        public async Task<IActionResult> UpdateSubCategoryAsync(UpdateSubCategoryDto updateSubCategoryDto)
        {
            await _subCategoryService.TUpdateAsync(new SubCategory()
            {
                SubCategoryName = updateSubCategoryDto.SubCategoryName,
                Id = updateSubCategoryDto.Id,
                CategoryId = updateSubCategoryDto.CategoryId,
            });

            return Ok("SubCategory Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public async Task<IActionResult> ToggleStatusAsync(int id)
        {
            await _subCategoryService.TToggleStatusAsync(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public async Task<IActionResult> GetListByStatusTrueAsync()
        {
            return Ok(await _subCategoryService.TGetListByStatusTrueAsync());
        }       
    }
}
