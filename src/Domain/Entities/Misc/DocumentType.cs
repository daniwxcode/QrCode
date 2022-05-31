using QrCode.Domain.Contracts;

namespace QrCode.Domain.Entities.Misc
{
    public class DocumentType : AuditableEntity<int>
    {
        public string Name { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double Size { get; set; }
        public string Description { get; set; }
    }
}