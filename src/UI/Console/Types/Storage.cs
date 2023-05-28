using Domain.DTO;
using UI.Console.Enums;
using UI.Console.Utilities;

namespace UI.Console.Types;

public record Storage()
{
	// public PageResult? PageResult { get; init; } = null;
	public GameDTO? Game { get; set; } = null;
	public GameDTO[]? Games { get; set; } = null;
	public Page? Page { get; set; } = null;
	public Router Router { get; set; } = new Router();
	public string? InputValue { get; set; } = null;
	public string[]? InputValues { get; set; } = null;
	public ComponentId? ComponentId { get; set; } = null;
	public bool IsGamePaused { get; set; } = false;
	public bool IsGamePlayed { get; set; } = false;
	public bool IsGameQuit { get; set; } = false;
	// public InputResult? InputResult { get; init; } = null;
	// public FormResult? FormResult { get; init; } = null;
	// public ButtonResult? ButtonResult { get; init; } = null;
}