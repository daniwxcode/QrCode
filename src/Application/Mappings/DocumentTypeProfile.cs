using AutoMapper;
using QrCode.Application.Features.DocumentTypes.Commands.AddEdit;
using QrCode.Application.Features.DocumentTypes.Queries.GetAll;
using QrCode.Application.Features.DocumentTypes.Queries.GetById;
using QrCode.Domain.Entities.Misc;

namespace QrCode.Application.Mappings
{
    public class DocumentTypeProfile : Profile
    {
        public DocumentTypeProfile()
        {
            CreateMap<AddEditDocumentTypeCommand, DocumentType>().ReverseMap();
            CreateMap<GetDocumentTypeByIdResponse, DocumentType>().ReverseMap();
            CreateMap<GetAllDocumentTypesResponse, DocumentType>().ReverseMap();
        }
    }
}