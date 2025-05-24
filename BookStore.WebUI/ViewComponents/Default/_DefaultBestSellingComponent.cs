using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.ProductDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.Default
{
    public class _DefaultBestSellingComponent : ViewComponent
    {
        private readonly IProductService _productService;
        private readonly IMapper _mapper;
        private readonly Random _random = new Random();

        public _DefaultBestSellingComponent(IProductService productService, IMapper mapper)
        {
            _productService = productService;
            _mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var products = _productService.TGetProductWithAuthors();
            var dtoList = _mapper.Map<List<ResultProductDto>>(products);

            if (dtoList == null || dtoList.Count == 0)
                return View(null); // veya boş bir View dönebilirsin

            var randomIndex = _random.Next(dtoList.Count);
            var selectedProduct = dtoList[randomIndex];

            return View(selectedProduct);
        }
    }
}
