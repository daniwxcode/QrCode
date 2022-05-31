
using QrCode.Application.Interfaces.Serialization.Settings;
using Newtonsoft.Json;

namespace QrCode.Application.Serialization.Settings
{
    public class NewtonsoftJsonSettings : IJsonSerializerSettings
    {
        public JsonSerializerSettings JsonSerializerSettings { get; } = new();
    }
}