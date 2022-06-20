using QrCode.Domain.Contracts;
using QrCode.Domain.Entities.ExtendedAttributes;
using System;

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

        public override bool Equals (object obj)
        {
            return obj is Document document &&
                   Id == document.Id &&
                   Localité == document.Localité &&
                   Owner == document.Owner &&
                   Requisition == document.Requisition &&
                   Superficie == document.Superficie &&
                   NumeroTitreFoncier == document.NumeroTitreFoncier &&
                   Description == document.Description &&
                   URL == document.URL &&
                   DocumentTypeId == document.DocumentTypeId;
        }

        public override int GetHashCode ()
        {
            HashCode hash = new HashCode();
            hash.Add(Id);
            hash.Add(Localité);
            hash.Add(Owner);
            hash.Add(Requisition);
            hash.Add(Superficie);
            hash.Add(NumeroTitreFoncier);
            hash.Add(Description);
            hash.Add(URL);
            hash.Add(DocumentTypeId);
            return hash.ToHashCode();
        }
    }
}