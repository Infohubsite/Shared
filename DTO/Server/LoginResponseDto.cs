using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record LoginResponseDto
    {
        [JsonPropertyName("token")] public required string Token { get; init; }
    }
}
