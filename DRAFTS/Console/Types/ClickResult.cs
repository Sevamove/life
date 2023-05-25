using Domain.DTO;
using UI.Console.Enums;

namespace UI.Console.Types;

public record ClickResult()
{
	public required GameDTO[]? GameDTOs;
	// Similar to the HTML href element's property.
	public required Page? Page;
}