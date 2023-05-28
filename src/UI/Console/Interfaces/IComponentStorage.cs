using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponentStorage
{
	public void SetComponentStorage(Storage storage);
	public Storage GetComponentStorage();
	// public void SetGame(GameDTO game);
	// public GameDTO? Game();
}