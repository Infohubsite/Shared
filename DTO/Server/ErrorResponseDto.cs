using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record ErrorResponseDto
    {
        [JsonPropertyName("message")] public required string Message { get; init; }
    }
}
