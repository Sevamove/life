using Domain.DTO;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Utilities;

public class LocalStorage : ILocalStorage
{
	private ComponentResult? storage;
	// private GameDTO? game;

	// public GameDTO? Game()
	// {
	// 	return this.game;
	// }

	// public void SetGame(GameDTO game)
	// {
	// 	this.game = game;
	// }

	public void SetStorage(ComponentResult storage)
	{
		this.storage = storage;
	}

	public ComponentResult? Storage()
	{
		return this.storage;
	}
}