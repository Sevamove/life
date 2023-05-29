using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record PositionEntity
{
	[JsonPropertyName("X")]
	public required int X { get; init; }
	[JsonPropertyName("Y")]
	public required int Y { get; init; }
}