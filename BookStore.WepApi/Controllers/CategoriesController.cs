using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriesController : ControllerBase
    {
        private readonly ICategoryService _categoryService;

        public CategoriesController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var categories = _categoryService.TGetAll();
            return Ok(categories);
        }

        [HttpPost]
        public IActionResult Insert(Category model)
        {
            _categoryService.TInsert(model);
            return Ok("Ekleme İşlemi Başarılı");
        }

        [HttpPut]
        public IActionResult Update(Category model)
        {
            _categoryService.TUpdate(model);
            return Ok("Güncelleme İşlemi Başarılı");
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            _categoryService.TDelete(id);
            return Ok("Silme İşlemi Başarılı ");
        }
    }
}
