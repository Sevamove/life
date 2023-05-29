using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record CellEntity : BaseEntity
{
	[JsonPropertyName("State")]
	public required int State { get; init; }
	[JsonPropertyName("Position")]
	public required PositionEntity Position { get; init; }
}