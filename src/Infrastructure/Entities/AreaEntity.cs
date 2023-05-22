using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record AreaEntity
{
	[JsonPropertyName("width")]
	public required int Width { get; init; }
	[JsonPropertyName("height")]
	public required int Height { get; init; }
}