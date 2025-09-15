using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record CreateEntityDefinitionDto
    {
        [JsonPropertyName("name")][Required(ErrorMessage = "Entity name is required")][StringLength(100, MinimumLength = 2, ErrorMessage = "Name must be between 2 and 100 characters")] public required string Name { get; init; }
    }
}