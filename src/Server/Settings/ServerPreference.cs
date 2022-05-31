using System.Linq;
using QrCode.Shared.Constants.Localization;
using QrCode.Shared.Settings;

namespace QrCode.Server.Settings
{
    public record ServerPreference : IPreference
    {
        public string LanguageCode { get; set; } = LocalizationConstants.SupportedLanguages.FirstOrDefault()?.Code ?? "fr-FR";

        //TODO - add server preferences
    }
}