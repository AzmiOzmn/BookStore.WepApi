using BookStore.BusinessLayer.Abstract;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AuthorsController : ControllerBase
    {
        private readonly IAuthorService authorService;

        public AuthorsController(IAuthorService authorService)
        {
            this.authorService = authorService;
        }

        [HttpGet]

        public IActionResult GetAll()
        {
            return Ok (authorService.TGetAll());
        }

        [HttpPost]

        public IActionResult Insert(Author author)
        {
            authorService.TInsert(author);
            return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult Update(Author author)
        {
            authorService.TUpdate(author);
            return Ok("Güncelleme işlemi başarılı");
        }

        [HttpDelete]
        public IActionResult Delete(int id)
        {
            authorService.TDelete(id);
            return Ok("Silme işlemi başarılı");
        }
        [HttpGet("GetAuthor")]

        public IActionResult GetAuthor(int id) 
        {
            return Ok(authorService.TGetById(id));
        }

    }
}
