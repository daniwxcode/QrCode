using QrCode.Client.Infrastructure.Extensions;
using QrCode.Shared.Wrapper;
using System.Net.Http;
using System.Threading.Tasks;
using QrCode.Application.Features.Dashboards.Queries.GetData;

namespace QrCode.Client.Infrastructure.Managers.Dashboard
{
    public class DashboardManager : IDashboardManager
    {
        private readonly HttpClient _httpClient;

        public DashboardManager(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<IResult<DashboardDataResponse>> GetDataAsync()
        {
            var response = await _httpClient.GetAsync(Routes.DashboardEndpoints.GetData);
            var data = await response.ToResult<DashboardDataResponse>();
            return data;
        }
    }
}