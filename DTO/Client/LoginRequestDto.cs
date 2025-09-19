using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record LoginRequestDto
    {
        [JsonPropertyName("username")] public required string Username { get; init; }
        [JsonPropertyName("password")] public required string Password { get; init; }
    }
}
