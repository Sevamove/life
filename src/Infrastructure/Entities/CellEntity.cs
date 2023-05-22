using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record CellEntity : BaseEntity
{
	[JsonPropertyName("state")]
	public required int State { get; init; }
	[JsonPropertyName("position")]
	public required PositionEntity Position { get; init; }
}