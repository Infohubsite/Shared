using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record KoofrUploadDto
    {
        [JsonPropertyName("url")] public required string Url { get; init; }
    }
}
