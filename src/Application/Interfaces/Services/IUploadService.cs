using QrCode.Application.Requests;

namespace QrCode.Application.Interfaces.Services
{
    public interface IUploadService
    {
        (string dbpath, string fullpath) UploadAsync (UploadRequest request);
    }
}