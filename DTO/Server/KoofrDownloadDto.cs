using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record KoofrDownloadDto
    {
        [JsonPropertyName("url")] public required string Url { get; init; }
    }
}
