using AutoMapper;
using QrCode.Application.Interfaces.Repositories;
using QrCode.Application.Interfaces.Services;
using QrCode.Application.Requests;
using QrCode.Domain.Entities.Misc;
using QrCode.Shared.Wrapper;
using MediatR;
using System;
using System.ComponentModel.DataAnnotations;
using System.Threading;
using System.Threading.Tasks;
using Microsoft.Extensions.Localization;

namespace QrCode.Application.Features.Documents.Commands.AddEdit
{
    public partial class AddEditDocumentCommand : IRequest<Result<int>>
    {
        public int Id { get; set; }

        [Required]
        public string Localité { get; set; }
        [Required]
        public string Owner { get; set; }
        [Required]
        public string NumeroTitreFoncier { get; set; }
        [Required]
        public string Requisition { get; set; }
        [Required]
        public string Superficie { get; set; }
      
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        [Required]
        public string URL { get; set; }
        [Required]
        public int DocumentTypeId { get; set; }
        [Required]
        public UploadRequest UploadRequest { get; set; }
    }

    internal class AddEditDocumentCommandHandler : IRequestHandler<AddEditDocumentCommand, Result<int>>
    {
        private readonly IStampService _stampService;
        private readonly IMapper _mapper;
        private readonly IUnitOfWork<int> _unitOfWork;
        private readonly IUploadService _uploadService;
        private readonly IStringLocalizer<AddEditDocumentCommandHandler> _localizer;

        public AddEditDocumentCommandHandler(IUnitOfWork<int> unitOfWork, IMapper mapper, IUploadService uploadService, IStringLocalizer<AddEditDocumentCommandHandler> localizer, IStampService stampService)
        {
            _unitOfWork = unitOfWork;
            _mapper = mapper;
            _uploadService = uploadService;
            _localizer = localizer;
            _stampService = stampService;
        }

        public async Task<Result<int>> Handle(AddEditDocumentCommand command, CancellationToken cancellationToken)
        {
            (string dbpath, string fullpath) result = new();
            var uploadRequest = command.UploadRequest;
            if (uploadRequest != null)
            {
                uploadRequest.FileName = $"D-{Guid.NewGuid()}{uploadRequest.Extension}";
            }
           
            if (command.Id == 0)
            {
                var doc = _mapper.Map<Document>(command);
                if (uploadRequest != null)
                {
                    
                    result= _uploadService.UploadAsync(uploadRequest);
                    doc.URL = result.dbpath;
                }
                await _unitOfWork.Repository<Document>().AddAsync(doc);
                await _unitOfWork.Commit(cancellationToken);

                await _stampService.StampQrCodeAsync(uploadRequest,result.fullpath, command.DocumentTypeId);
                return await Result<int>.SuccessAsync(doc.Id, _localizer["Document Saved"]);
            }
            else
            {
                var doc = await _unitOfWork.Repository<Document>().GetByIdAsync(command.Id);
                if (doc != null)
                {  
                    doc.Description = command.Description ?? doc.Description;
                    doc.IsPublic = command.IsPublic;
                    if (uploadRequest != null)
                    {
                        result = _uploadService.UploadAsync(uploadRequest);
                        doc.URL = result.dbpath;
                      
                    }
                    doc.DocumentTypeId = (command.DocumentTypeId == 0) ? doc.DocumentTypeId : command.DocumentTypeId;
                    await _unitOfWork.Repository<Document>().UpdateAsync(doc);
                    await _unitOfWork.Commit(cancellationToken);
                    return await Result<int>.SuccessAsync(doc.Id, _localizer["Document Updated"]);
                }
                else
                {
                    return await Result<int>.FailAsync(_localizer["Document Not Found!"]);
                }
            }
        }
    }
}