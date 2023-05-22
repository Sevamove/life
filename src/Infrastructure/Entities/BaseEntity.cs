using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record BaseEntity
{
	[JsonPropertyName("id")]
	public required string Id { get; init; }
}