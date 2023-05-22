using System.Text.Json.Serialization;
using Domain.Entities;

namespace Infrastructure.Entities;

public record PatternEntity : BaseEntity
{
	[JsonPropertyName("name")]
	public required string Name { get; init; }
	[JsonPropertyName("minimum_area_needed")]
	public required AreaEntity MinimumAreaNeeded { get; init; }
	[JsonPropertyName("cells")]
	public required Cell[] Cells { get; init; }
}