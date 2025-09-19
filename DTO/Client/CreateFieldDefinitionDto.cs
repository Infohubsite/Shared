using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateFieldDefinitionDto
    {
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("dataType")] public required Enum.DataType DataType { get; init; }
        [JsonPropertyName("isRequired")] public required bool IsRequired { get; init; }
        [JsonPropertyName("isList")] public required bool IsList { get; init; }
        [JsonPropertyName("referenceTargetEntityDefinitionId")] public Guid? ReferenceTargetEntityDefinitionId { get; init; }
    }
}
