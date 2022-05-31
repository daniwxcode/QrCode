using AutoMapper;
using QrCode.Application.Requests.Identity;
using QrCode.Application.Responses.Identity;

namespace QrCode.Client.Infrastructure.Mappings
{
    public class RoleProfile : Profile
    {
        public RoleProfile()
        {
            CreateMap<PermissionResponse, PermissionRequest>().ReverseMap();
            CreateMap<RoleClaimResponse, RoleClaimRequest>().ReverseMap();
        }
    }
}