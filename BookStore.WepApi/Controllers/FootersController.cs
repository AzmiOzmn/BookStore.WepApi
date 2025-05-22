using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class FootersController : ControllerBase
    {
        private readonly IFooterService _footerService;

        public FootersController(IFooterService footerService)
        {
            _footerService = footerService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var footers = _footerService.TGetAll();
            return Ok(footers);
        }

        [HttpPost]
        public IActionResult Insert(Footer model)
        {
            _footerService.TInsert(model);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut]
        public IActionResult Update(Footer model)
        {
            _footerService.TUpdate(model);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _footerService.TDelete(id);
            return Ok("Silme İşlemi Başarılı ");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var footer = _footerService.TGetById(id);
            if (footer == null)
            {
                return NotFound("Footer not found");
            }
            return Ok(footer);
        }
    }
}
