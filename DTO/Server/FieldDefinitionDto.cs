using Shared.Enum;
using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record FieldDefinitionDto
    {
        [JsonPropertyName("id")] public required Guid Id { get; init; }
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("dataType")] public required DataType DataType { get; init; }
        [JsonPropertyName("isRequired")] public required bool IsRequired { get; init; }
        [JsonPropertyName("isList")] public required bool IsList { get; init; }
        [JsonPropertyName("entityDefinitionId")] public required Guid EntityDefinitionId { get; init; }
        [JsonPropertyName("referenceTargetEntityDefinitionId")] public Guid? ReferenceTargetEntityDefinitionId { get; init; }
    }
}
