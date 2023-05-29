using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record GridEntity
{
	[JsonPropertyName("Area")]
	public required AreaEntity Area { get; init; }
	[JsonPropertyName("Cells")]
	public required CellEntity[,] Cells { get; init; }
}