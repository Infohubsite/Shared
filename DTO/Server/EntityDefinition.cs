using System.Text.Json.Serialization;

namespace Shared.DTO.Server
{
    public record EntityDefinition : IComparable<EntityDefinition>
    {
        [JsonPropertyName("id")] public required Guid Id { get; init; }
        [JsonPropertyName("name")] public required string Name { get; init; }
        [JsonPropertyName("fields")] public List<FieldDefinition> Fields { get; init; } = [];

        public int CompareTo(EntityDefinition? other)
        {
            if (other is null) return 1;
            return string.Compare(Name, other.Name, StringComparison.Ordinal);
        }
    }
}
