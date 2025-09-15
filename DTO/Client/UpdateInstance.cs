using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record UpdateInstance
    {
        [JsonPropertyName("data")] public Dictionary<string, object?> Data { get; init; } = [];
    }
}
