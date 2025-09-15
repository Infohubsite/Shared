using System.ComponentModel.DataAnnotations;
using System.Text.Json.Serialization;

namespace Shared.DTO.Client
{
    public record LoginRequest
    {
        [JsonPropertyName("username")][Required(ErrorMessage = "Username is required")] public required string Username { get; init; }
        [JsonPropertyName("password")][Required(ErrorMessage = "Password is required")] public required string Password { get; init; }
    }
}
