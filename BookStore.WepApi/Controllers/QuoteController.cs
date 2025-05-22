using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.QuoteDtos;
using BookStore.EntityLayer.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WepApi.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class QuoteController : ControllerBase
    {
        private readonly IQuoteService _quoteService;
        private readonly IMapper _mapper;

        public QuoteController(IQuoteService quoteService, IMapper mapper)
        {
            _quoteService = quoteService;
            _mapper = mapper;
        }

        [HttpGet]
        public IActionResult GetAll()
        {
            var quotes = _quoteService.TGetQuoteWithAuthors();
            var dto = _mapper.Map<List<ResultQuoteDto>>(quotes);
            return Ok(dto);
        }
        [HttpPost]
        public IActionResult Insert(InsertQuoteDto dto)
        {
            if (!ModelState.IsValid)
                return BadRequest(ModelState);

            var quote = _mapper.Map<Quote>(dto);
            _quoteService.TInsert(quote);

            return Ok("Ekleme işlemi başarılı");
        }

        [HttpPut]
        public IActionResult Update(Quote model)
        {
            _quoteService.TUpdate(model);
            return Ok("Güncelleme İşlemi Başarılı");
        }
        [HttpDelete]
        public IActionResult Delete(int id)
        {
            _quoteService.TDelete(id);
            return Ok("Silme İşlemi Başarılı ");
        }
        [HttpGet("{id}")]
        public IActionResult GetById(int id)
        {
            var quote = _quoteService.TGetById(id);
            if (quote == null)
            {
                return NotFound("Quote not found");
            }
            return Ok(quote);
        }
    }
}
