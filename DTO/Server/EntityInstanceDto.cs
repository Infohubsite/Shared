using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record EntityInstanceDto
    {
        [JsonPropertyName("id")] public required Guid Id { get; init; }
        [JsonPropertyName("entityDefinitionId")] public required Guid EntityDefinitionId { get; init; }
        [JsonPropertyName("data")] public Dictionary<string, object?> Data { get; init; } = [];
    }
}
