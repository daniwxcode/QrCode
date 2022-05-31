using QrCode.Shared.Wrapper;
using System.Threading.Tasks;
using QrCode.Application.Features.Dashboards.Queries.GetData;

namespace QrCode.Client.Infrastructure.Managers.Dashboard
{
    public interface IDashboardManager : IManager
    {
        Task<IResult<DashboardDataResponse>> GetDataAsync();
    }
}