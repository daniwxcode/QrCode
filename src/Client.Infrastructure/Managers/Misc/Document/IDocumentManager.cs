using QrCode.Application.Features.Documents.Commands.AddEdit;
using QrCode.Application.Features.Documents.Queries.GetAll;
using QrCode.Application.Requests.Documents;
using QrCode.Shared.Wrapper;
using System.Threading.Tasks;
using QrCode.Application.Features.Documents.Queries.GetById;

namespace QrCode.Client.Infrastructure.Managers.Misc.Document
{
    public interface IDocumentManager : IManager
    {
        Task<PaginatedResult<GetAllDocumentsResponse>> GetAllAsync(GetAllPagedDocumentsRequest request);

        Task<IResult<GetDocumentByIdResponse>> GetByIdAsync(GetDocumentByIdQuery request);

        Task<IResult<int>> SaveAsync(AddEditDocumentCommand request);

        Task<IResult<int>> DeleteAsync(int id);
    }
}