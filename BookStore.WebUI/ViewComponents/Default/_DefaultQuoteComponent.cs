using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.QuoteDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.Default
{
    public class _DefaultQuoteComponent : ViewComponent
    {
        private readonly IMapper mapper;
        private readonly IQuoteService quoteService;

        public _DefaultQuoteComponent(IMapper mapper, IQuoteService quoteService)
        {
            this.mapper = mapper;
            this.quoteService = quoteService;
        }

        public IViewComponentResult Invoke()
        {
            var values = quoteService.TGetQuoteWithAuthors();
            var dto = mapper.Map<List<ResultQuoteDto>>(values);
            return View(dto);
        }
    }
}
