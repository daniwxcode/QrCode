using System.Collections.Generic;
using System.Threading.Tasks;
using QrCode.Application.Interfaces.Common;
using QrCode.Application.Requests.Identity;
using QrCode.Application.Responses.Identity;
using QrCode.Shared.Wrapper;

namespace QrCode.Application.Interfaces.Services.Identity
{
    public interface IRoleClaimService : IService
    {
        Task<Result<List<RoleClaimResponse>>> GetAllAsync();

        Task<int> GetCountAsync();

        Task<Result<RoleClaimResponse>> GetByIdAsync(int id);

        Task<Result<List<RoleClaimResponse>>> GetAllByRoleIdAsync(string roleId);

        Task<Result<string>> SaveAsync(RoleClaimRequest request);

        Task<Result<string>> DeleteAsync(int id);
    }
}