using Domain.DTO;
using UI.Console.Enums;

namespace UI.Console.Types;

public record ButtonResult()
{
	public GameDTO[]? Games { get; init; } = null;
	public GameDTO? Game { get; init; } = null;
	// Similar to the HTML href element's property.
	public Page? Page { get; init; } = null;
}