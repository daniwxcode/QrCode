namespace QrCode.Application.Features.DocumentTypes.Queries.GetById
{
    public class GetDocumentTypeByIdResponse
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public double PositionX { get; set; }
        public double PositionY { get; set; }
        public double Size { get; set; }
        public string Description { get; set; }
    }
}