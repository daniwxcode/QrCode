using System;

namespace QrCode.Application.Features.Documents.Queries.GetAll
{
    public class GetAllDocumentsResponse
    {
        public int Id { get; set; }
        //public string Title { get; set; }
        public string Owner { get; set; }
        public string Requisition { get; set; }
        public string Superficie { get; set; }
        public string CreatedBy { get; set; }
  
        public string URL { get; set; }
        public string DocumentType { get; set; }
       
    }
}