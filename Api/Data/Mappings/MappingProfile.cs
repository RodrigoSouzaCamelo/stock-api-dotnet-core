using Api.Data.Entities;
using Api.Data.Models;
using AutoMapper;

namespace Api.Data.Mappings
{
    public class MappingProfile : Profile
    {
        public MappingProfile()
        {
            CreateMap<Value, ValueModel>()
                .ForMember(x => x.b, y => y.MapFrom(x => x.a))
                .ReverseMap();
        }
    }
}