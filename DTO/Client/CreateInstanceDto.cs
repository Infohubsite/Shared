using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateInstanceDto
    {
        [JsonPropertyName("data")] public Dictionary<string, object?> Data { get; init; } = [];
    }
}
