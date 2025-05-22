using AutoMapper;
using BookStore.DtoLayer.ProductDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class ProductMapping : Profile
    {
        public ProductMapping()
        {
            CreateMap<Product, ResultProductDto>()
                .ForMember(dest => dest.AuthorName, opt => opt.MapFrom(src => src.Author.Name)).ReverseMap();
        }
    }
}
