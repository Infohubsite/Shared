using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record ErrorResponse
    {
        [JsonPropertyName("message")] public required string Message { get; init; }
    }
}
