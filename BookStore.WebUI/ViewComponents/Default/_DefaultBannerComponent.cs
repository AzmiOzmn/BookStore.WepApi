using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.Default
{
    public class _DefaultBannerComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper mapper;

        public _DefaultBannerComponent(IMapper mapper, IProductService productService)
        {
            this.mapper = mapper;
            _productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = _productService.TGetProductWithAuthors();
            var model = mapper.Map<List<ResultProductDto>>(values);


            return View(model);
        }
    }
}
