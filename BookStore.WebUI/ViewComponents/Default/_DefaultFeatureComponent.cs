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

          
            var latest4Books = values.OrderByDescending(x => x.ProductId).Take(4).ToList();

            var dto = _mapper.Map<List<ResultProductDto>>(latest4Books);
            return View(dto);
        }

    }
}
