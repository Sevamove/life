using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record AreaEntity
{
	[JsonPropertyName("Width")]
	public required int Width { get; init; }
	[JsonPropertyName("Height")]
	public required int Height { get; init; }
}