using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class SubscribeController : ControllerBase
    {
        private readonly ISubscribeService subscribeService;

        public SubscribeController(ISubscribeService subscribeService)
        {
            this.subscribeService = subscribeService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var subscribes = subscribeService.TGetAll();
            return Ok(subscribes);
        }
        [HttpPost]
        public IActionResult Insert(Subscribe model)
        {
            subscribeService.TInsert(model);
            return Ok("Ekleme İşlemi Başarılı");
        }
        [HttpPut]
        public IActionResult Update(Subscribe model)
        {
            subscribeService.TUpdate(model);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            subscribeService.TDelete(id);
            return Ok("Silme İşlemi Başarılı ");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var subscribe = subscribeService.TGetById(id);
            if (subscribe == null)
            {
                return NotFound("Subscribe not found");
            }
            return Ok(subscribe);
        }

    }
}
