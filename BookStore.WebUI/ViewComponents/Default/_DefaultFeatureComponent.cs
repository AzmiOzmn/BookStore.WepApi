using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.Default
{
    public class _DefaultFeatureComponent : ViewComponent
    {
        private readonly IMapper _mapper;
        private readonly IProductService productService;

        public _DefaultFeatureComponent(IMapper mapper, IProductService productService)
        {
            _mapper = mapper;
            this.productService = productService;
        }

        public IViewComponentResult Invoke()
        {
            var values = productService.TGetProductWithAuthors();
            var dto = _mapper.Map<List<ResultProductDto>>(values);
            return View(dto);
        }
    }
}
