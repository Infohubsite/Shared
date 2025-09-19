using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record UpdateFieldDefinitionDto
    {
        [JsonPropertyName("name")] public required string Name { get; init; }
    }
}
