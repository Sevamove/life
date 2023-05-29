using System.Text.Json.Serialization;
using Domain.Entities;

namespace Infrastructure.Entities;

public record PatternEntity : BaseEntity
{
	[JsonPropertyName("Name")]
	public required string Name { get; init; }
	[JsonPropertyName("Minimum_area_needed")]
	public required AreaEntity MinimumAreaNeeded { get; init; }
	[JsonPropertyName("Cells")]
	public required Cell[] Cells { get; init; }
}