using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.ProductDtos;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService productService;
        private readonly IMapper mapper;

        // IMapper bağımlılığını da constructor'a ekledik
        public ProductsController(IProductService productService, IMapper mapper)
        {
            this.productService = productService;
            this.mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var values = productService.TGetProductWithAuthors(); 
            var dto = mapper.Map<List<ResultProductDto>>(values);
            return Ok(dto);
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
            return Ok("Güncelleme işlemi başarılı");
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
    }
}
