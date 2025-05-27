using AutoMapper;
using BookStore.BusinessLayer.Abstract;
using BookStore.DtoLayer.FooterDtos;
using Microsoft.AspNetCore.Mvc;

namespace BookStore.WebUI.ViewComponents.UILayout
{
    public class _FooterComponent : ViewComponent
    {
        private readonly IFooterService footerService;
        private readonly IMapper mapper;

        public _FooterComponent(IFooterService footerService, IMapper mapper)
        {
            this.footerService = footerService;
            this.mapper = mapper;
        }

        public IViewComponentResult Invoke()
        {
            var footer = footerService.TGetAll();
            var footerViewModel = mapper.Map<List<ResultFooterDto>>(footer);
            return View(footerViewModel);
        }
    }
    
   }

