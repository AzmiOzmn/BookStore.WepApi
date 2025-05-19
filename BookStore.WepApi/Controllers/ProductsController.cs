using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;

        public ProductsController(IProductService productService)
        {
            this.productService = productService;
        }

        [HttpGet]
        public IActionResult GetAll()
        {  
            return Ok(productService.TGetAll());
        }

        [HttpPost]
        public IActionResult Insert(Product product)
        {
           productService.TInsert(product);
           return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult Update(Product product)
        {
            productService.TUpdate(product);
            return Ok("Güncelleme İşlemi Başarılı");
        }

        [HttpDelete]

        public IActionResult Delete(int id)
        {
            productService.TDelete(id);
            return Ok("Silme işlemi başarılı");
        }

        [HttpGet("GetProduct")]
        public IActionResult GetProduct(int id)
        {
            return Ok(productService.TGetById(id));
        }

        [HttpGet("ProductCount")]

        public IActionResult ProductCount()
        {
            return Ok(productService.TGetProductCount());
        }
    }
}
