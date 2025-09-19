using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateEntityDefinitionDto
    {
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("fields")] public List<CreateFieldDefinitionDto> Fields { get; init; } = [];
    }
}