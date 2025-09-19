using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record EntityDefinitionDto
    {
        [JsonPropertyName("id")] public required Guid Id { get; init; }
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("fields")] public List<FieldDefinitionDto> Fields { get; init; } = [];
    }
}
