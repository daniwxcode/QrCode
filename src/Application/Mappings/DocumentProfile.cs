using AutoMapper;
using QrCode.Application.Features.Documents.Commands.AddEdit;
using QrCode.Application.Features.Documents.Queries.GetById;
using QrCode.Domain.Entities.Misc;

namespace QrCode.Application.Mappings
{
    public class DocumentProfile : Profile
    {
        public DocumentProfile()
        {
            CreateMap<AddEditDocumentCommand, Document>().ReverseMap();
            CreateMap<GetDocumentByIdResponse, Document>().ReverseMap();
        }
    }
}