using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface ILocalStorage
{
	public void SetLocalStorage(Storage storage);
	public Storage GetLocalStorage();
	// public void SetGame(GameDTO game);
	// public GameDTO? Game();
}