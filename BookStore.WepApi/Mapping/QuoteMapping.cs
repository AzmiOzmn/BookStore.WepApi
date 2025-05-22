using AutoMapper;
using BookStore.DtoLayer.QuoteDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class QuoteMapping : Profile
    {
        public QuoteMapping()
        {
            CreateMap<Quote, ResultQuoteDto>().ReverseMap();
            CreateMap<Quote, UpdateQuoteDto>().ReverseMap();
            CreateMap<Quote, InsertQuoteDto>().ReverseMap();
            CreateMap<Quote, GetByIdQuoteDto>().ReverseMap();
        }
    }
}
