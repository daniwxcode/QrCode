using QrCode.Application.Interfaces.Common;

namespace QrCode.Application.Interfaces.Services
{
    public interface ICurrentUserService : IService
    {
        string UserId { get; }
    }
}