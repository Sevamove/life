using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record PositionEntity
{
	[JsonPropertyName("x")]
	public required int X { get; init; }
	[JsonPropertyName("y")]
	public required int Y { get; init; }
}