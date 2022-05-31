using System.Text.Json;
using QrCode.Application.Interfaces.Serialization.Options;

namespace QrCode.Application.Serialization.Options
{
    public class SystemTextJsonOptions : IJsonSerializerOptions
    {
        public JsonSerializerOptions JsonSerializerOptions { get; } = new();
    }
}