using QrCode.Application.Requests;

namespace QrCode.Application.Interfaces.Services
{
    public interface IUploadService
    {
        string UploadAsync(UploadRequest request);
    }
}