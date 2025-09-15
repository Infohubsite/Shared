using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record EntityDefinitionDto : IComparable<EntityDefinitionDto>
    {
        [JsonPropertyName("id")] public required Guid Id { get; init; }
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("fields")] public List<FieldDefinitionDto> Fields { get; init; } = [];

        public int CompareTo(EntityDefinitionDto? other)
        {
            if (other is null) return 1;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}
