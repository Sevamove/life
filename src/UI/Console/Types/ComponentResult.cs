using Domain.DTO;
using UI.Console.Enums;

namespace UI.Console.Types;

public record ComponentResult()
{
	// public PageResult? PageResult { get; init; } = null;
	public GameDTO? Game { get; init; } = null;
	public GameDTO[]? Games { get; init; } = null;
	public Page? Page { get; init; } = null;
	public string? InputValue { get; init; } = null;
	public string[]? InputValues { get; init; } = null;
	public ComponentId? ComponentId { get; init; } = null;
	public bool IsGamePaused { get; init; } = false;
	public bool IsGamePlayed { get; init; } = false;
	public bool IsGameQuit { get; init; } = false;
	// public InputResult? InputResult { get; init; } = null;
	// public FormResult? FormResult { get; init; } = null;
	// public ButtonResult? ButtonResult { get; init; } = null;
}