using System.Text.Json.Serialization;

namespace Infrastructure.Entities;

public record GridEntity
{
	[JsonPropertyName("area")]
	public required AreaEntity Area { get; init; }
	[JsonPropertyName("cells")]
	public required CellEntity[] Cells { get; init; }
}