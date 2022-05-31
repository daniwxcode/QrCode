using AutoMapper;
using QrCode.Infrastructure.Models.Audit;
using QrCode.Application.Responses.Audit;

namespace QrCode.Infrastructure.Mappings
{
    public class AuditProfile : Profile
    {
        public AuditProfile()
        {
            CreateMap<AuditResponse, Audit>().ReverseMap();
        }
    }
}