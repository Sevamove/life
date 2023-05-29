using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponentStorage
{
	public void SetComponentStorage(Storage storage);
	public void ResetComponentStorage();
	// public void SetGame(GameDTO game);
	// public GameDTO? Game();
}