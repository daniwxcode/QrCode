using QrCode.Application.Interfaces.Common;
using QrCode.Application.Requests.Identity;
using QrCode.Application.Responses.Identity;
using QrCode.Shared.Wrapper;
using System.Threading.Tasks;

namespace QrCode.Application.Interfaces.Services.Identity
{
    public interface ITokenService : IService
    {
        Task<Result<TokenResponse>> LoginAsync(TokenRequest model);

        Task<Result<TokenResponse>> GetRefreshTokenAsync(RefreshTokenRequest model);
    }
}