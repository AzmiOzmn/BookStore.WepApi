using AutoMapper;
using BookStore.DtoLayer.FooterDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class FooterMapping : Profile
    {
        public FooterMapping()
        {
            CreateMap<Footer, ResultFooterDto>().ReverseMap();
            CreateMap<Footer, InsertFooterDto>().ReverseMap();
            CreateMap<Footer, UpdateFooterDto>().ReverseMap();
        }
    }

}

