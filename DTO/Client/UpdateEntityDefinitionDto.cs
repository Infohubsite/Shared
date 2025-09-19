using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record UpdateEntityDefinitionDto
    {
        [JsonPropertyName("name")] public required string Name { get; init; }
    }
}
