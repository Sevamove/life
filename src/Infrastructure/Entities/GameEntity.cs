using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record GameEntity : BaseEntity
{
	[JsonPropertyName("Name")]
	public required string Name { get; init; }
	[JsonPropertyName("Grid")]
	public required GridEntity Grid { get; init; }
}