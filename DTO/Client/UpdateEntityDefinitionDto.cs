using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record UpdateEntityDefinitionDto
    {
        [JsonPropertyName("name")][Required(ErrorMessage = "New entity name is required")][StringLength(100, MinimumLength = 2, ErrorMessage = "New name must be between 2 and 100 characters")] public required string Name { get; init; }
    }
}
