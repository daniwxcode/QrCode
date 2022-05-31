using System;

namespace QrCode.Application.Features.Documents.Queries.GetById
{
    public class GetDocumentByIdResponse
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Localité { get; set; }
        public string Owner { get; set; }
        public string Requisition { get; set; }
        public string Superficie { get; set; }
        public string NumeroTitreFoncier { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; }
        public string CreatedBy { get; set; }
        public DateTime CreatedOn { get; set; }
        public string URL { get; set; }
        public string DocumentType { get; set; }
        public int DocumentTypeId { get; set; }
    }
}