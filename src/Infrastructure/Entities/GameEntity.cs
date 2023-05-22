using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record GameEntity : BaseEntity
{
	[JsonPropertyName("name")]
	public required string Name { get; init; }
	[JsonPropertyName("grid")]
	public required GridEntity Grid { get; init; }
}