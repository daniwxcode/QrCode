using QrCode.Shared.Settings;
using System.Threading.Tasks;
using QrCode.Shared.Wrapper;

namespace QrCode.Shared.Managers
{
    public interface IPreferenceManager
    {
        Task SetPreference(IPreference preference);

        Task<IPreference> GetPreference();

        Task<IResult> ChangeLanguageAsync(string languageCode);
    }
}