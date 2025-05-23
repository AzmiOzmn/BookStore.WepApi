using AutoMapper;
using BookStore.DtoLayer.CategoryDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class CategoryMapping : Profile
    {
        public CategoryMapping()
        {

            CreateMap<Category, ResultCategoryDto>().ReverseMap();
            CreateMap<Category, InsertCategoryDto>().ReverseMap();
            CreateMap<Category, UpdateCategoryDto>().ReverseMap();

        }
    }

}

