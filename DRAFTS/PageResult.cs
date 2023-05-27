using Domain.DTO;
using UI.Console.Enums;

namespace UI.Console.Types;

public record PageResult()
{
	public GameDTO? Game { get; init; } = null;
	public Page? Page { get; init; } = null;
}