using AutoMapper;
using ShopService.Application.DTOs;
using ShopService.Domain.Entities;

namespace ShopService.Application.Mapper
{
    public class MapperProfile : Profile
    {
        public MapperProfile()
        {
            CreateMap<User, UserDTO>().ForMember(dest => dest.Id, opt => opt.MapFrom(src => src.Id))
                                      .ForMember(dest => dest.FullName, opt => opt.MapFrom(src => src.FullName))
                                      .ForMember(dest => dest.DateOfBirth, opt => opt.MapFrom(src => src.DateOfBirth));

        }
    }
}
