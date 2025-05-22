using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BannersController : ControllerBase
    {
         private readonly IBannerService bannerService;

        public BannersController(IBannerService bannerService)
        {
            this.bannerService = bannerService;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok(bannerService.TGetAll());
        }

        [HttpPost]

        public IActionResult Insert(Banner banner)
        {
            bannerService.TInsert(banner);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut]

        public IActionResult Update(Banner banner)
        {
            bannerService.TUpdate(banner);
            return Ok("Güncelleme işlemi başarılı");
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            bannerService.TDelete(id);
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetBanner")]

        public IActionResult GetBanner(int id)
        {
            return Ok(bannerService.TGetById(id));
        }

    }
}
