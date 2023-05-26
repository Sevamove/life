using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface ILocalStorage
{
	public void SetStorage(ComponentResult storage);
	public ComponentResult? Storage();
	// public void SetGame(GameDTO game);
	// public GameDTO? Game();
}