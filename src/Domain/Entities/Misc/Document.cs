using QrCode.Domain.Contracts;
using QrCode.Domain.Entities.ExtendedAttributes;

namespace QrCode.Domain.Entities.Misc
{
    public class Document : AuditableEntityWithExtendedAttributes<int, int, Document, DocumentExtendedAttribute>
    {      
        public string Localité { get; set; }
        public string Owner { get; set; }
        public string Requisition { get; set; }
        public string Superficie { get; set; }
        public string NumeroTitreFoncier { get; set; }
        public string Description { get; set; }
        public bool IsPublic { get; set; } = false;
        public string URL { get; set; }
        public int DocumentTypeId { get; set; }
        public virtual DocumentType DocumentType { get; set; }
    }
}