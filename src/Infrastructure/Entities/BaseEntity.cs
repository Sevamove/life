using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record BaseEntity
{
	[JsonPropertyName("Id")]
	public required string Id { get; init; }
}