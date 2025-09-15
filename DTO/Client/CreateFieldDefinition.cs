using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateFieldDefinition
    {
        [JsonPropertyName("name")][Required(ErrorMessage = "Field name is required")][StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")] public required string Name { get; init; }
        [JsonPropertyName("dataType")][Required(ErrorMessage = "Data type is required")] public required Enum.DataType DataType { get; init; }
        [JsonPropertyName("isRequired")] public bool IsRequired { get; init; } = true;
        [JsonPropertyName("isList")] public bool IsList { get; init; } = false;
        [JsonPropertyName("referenceTargetEntityDefinitionId")] public Guid? ReferenceTargetEntityDefinitionId { get; init; }
    }
}
