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

        //[HttpGet]
        //public IActionResult SubCategoryList()
        //{
        //    var value = _mapper.Map<List<ResultSubCategoryDto>>(_subCategoryService.TGetAll());
        //    return Ok(value);
        //}

        [HttpGet("GetSubCategoriesWithCategories")]
        public IActionResult GetSubCategoriesWithCategories()
        {
            var values = _subCategoryService.TGetSubCategoriesWithCategories();
            var result = _mapper.Map<List<ResultSubCategoryWithCategory>>(values);
            return Ok(result);
        }

        [HttpGet("SubCategoryCount")]
        public IActionResult SubCategoryCount()
        {
            return Ok(_subCategoryService.TSubCategoryCount());
        }


        [HttpGet("ActiveSubCategoryCount")]
        public IActionResult ActiveSubCategoryCount()
        {
            return Ok(_subCategoryService.TActiveSubCategoryCount());
        }


        [HttpGet("PassiveSubCategoryCount")]
        public IActionResult PassiveSubCategoryCount()
        {
            return Ok(_subCategoryService.TPassiveSubCategoryCount());
        }

        [HttpPost]
        public IActionResult CreateSubCategory(CreateSubCategoryDto createSubCategoryDto)
        {
            _subCategoryService.TAdd(new SubCategory()
            {
                SubCategoryName = createSubCategoryDto.SubCategoryName,
                CategoryId = createSubCategoryDto.CategoryId,               
            });

            return Ok("Kategori Eklendi");
        }

        [HttpDelete("{id}")]
        public IActionResult DeleteSubCategory(int id)
        {
            var value = _subCategoryService.TGetById(id);
            _subCategoryService.TDelete(value);
            return Ok("Kategori Silindi");
        }

        [HttpGet("{id}")]
        public IActionResult GetSubCategory(int id)
        {
            var value = _subCategoryService.TGetById(id);
            return Ok(value);
        }

        [HttpPut]
        public IActionResult UpdateSubCategory(UpdateSubCategoryDto updateSubCategoryDto)
        {
            _subCategoryService.TUpdate(new SubCategory()
            {
                SubCategoryName = updateSubCategoryDto.SubCategoryName,
                Id = updateSubCategoryDto.Id,
                CategoryId = updateSubCategoryDto.CategoryId,
            });

            return Ok("Kategori Güncellendi");
        }

        [HttpGet("ToggleStatus/{id}")]
        public IActionResult ToggleStatus(int id)
        {
            _subCategoryService.TToggleStatus(id);
            return Ok("Status Değiştirildi");
        }

        [HttpGet("GetListByStatusTrue")]
        public IActionResult GetListByStatusTrue()
        {
            return Ok(_subCategoryService.TGetListByStatusTrue());
        }       
    }
}
