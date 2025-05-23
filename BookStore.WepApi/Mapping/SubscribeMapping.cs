using AutoMapper;
using BookStore.DtoLayer.SubscribeDtos;
using BookStore.EntityLayer.Concrete;

namespace BookStore.WepApi.Mapping
{
    public class SubscribeMapping : Profile
    {
        public SubscribeMapping()
        {
            CreateMap<Subscribe, ResultSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, InsertSubscribeDto>().ReverseMap();
            CreateMap<Subscribe, UpdateSubscribeDto>().ReverseMap();
        }
    }

}

