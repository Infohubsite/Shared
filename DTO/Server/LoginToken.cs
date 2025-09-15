using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record LoginToken
    {
        [JsonPropertyName("token")] public required string Token { get; init; }
    }
}
