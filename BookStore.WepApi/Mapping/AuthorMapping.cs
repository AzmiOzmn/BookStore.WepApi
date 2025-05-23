using AutoMapper;
using BookStore.DtoLayer.AuthorDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class AuthorMapping : Profile
    {
        public AuthorMapping()
        {
            CreateMap<Author, ResultAuthorDto>().ReverseMap();
            CreateMap<Author, InsertAuthorDto>().ReverseMap();
            CreateMap<Author, UpdateAuthorDto>().ReverseMap();
        }
    }
}
