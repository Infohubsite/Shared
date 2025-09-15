using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateBulkFieldDefinitionDto
    {
        [JsonPropertyName("fields")][Required(ErrorMessage = "At least one field definition is required")][MinLength(1)] public required List<CreateFieldDefinitionDto> Fields { get; init; }
    }
}
