using AutoMapper;
using BookStore.DtoLayer.BannerDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class BannerMapping : Profile
    {
        public BannerMapping()
        {
            CreateMap<Banner, ResultBannerDto>().ReverseMap();
            CreateMap<Banner, InsertBannerDto>().ReverseMap();
            CreateMap<Banner, UpdateBannerDto>().ReverseMap();
            CreateMap<Banner, GetByIdBannerDto>().ReverseMap();
        }
    }
}
