using Domain.DTO;
using UI.Console.Enums;
using UI.Console.Utilities;

namespace UI.Console.Types;

public record Storage
{
	public GameDTO? Game { get; set; } = null;
	public GameDTO[]? Games { get; set; } = null;
	public Router Router { get; set; } = new Router();
	public ComponentId? ComponentId { get; set; } = null;
	public bool IsGamePaused { get; set; } = false;
	public bool IsGamePlayed { get; set; } = false;
	public bool IsGameQuit { get; set; } = false;
	public int RenderDelay { get; set; } = Timeout.Infinite;
	public string UserInput { get; set; } = String.Empty;
	public bool IsAnchorTriggered { get; set; } = false;
}