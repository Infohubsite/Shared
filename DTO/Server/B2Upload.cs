using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record B2Upload
    {
        [JsonPropertyName("token")] public required string Token { get; init; }
        [JsonPropertyName("url")] public required string Url { get; init; }
    }
}
