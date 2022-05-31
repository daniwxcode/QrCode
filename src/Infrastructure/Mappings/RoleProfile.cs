using AutoMapper;
using QrCode.Infrastructure.Models.Identity;
using QrCode.Application.Responses.Identity;

namespace QrCode.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<RoleResponse, BlazorHeroRole>().ReverseMap();
        }
    }
}