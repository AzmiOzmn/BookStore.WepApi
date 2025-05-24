using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.Default
{
    public class _DefaultPopularBooksComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductService _productService;

        public _DefaultPopularBooksComponent(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetProductsWithCategoryAndAuthor();
            var model = _mapper.Map<List<ResultProductDto>>(values);
            return View(model);
        }
    }
}
