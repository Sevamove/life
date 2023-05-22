using Infrastructure.DTO;

namespace UI.Console.Events;

public class GameNewEventSubscriber
{
	private GameDTO newGame;

	// Event handler method
	public void UpdateNewGame(GameDTO newGame)
	{
		this.newGame = newGame;
		System.Console.WriteLine("Event handled: " + newGame);
	}

	public GameDTO GetNewGame()
	{
		return this.newGame;
	}
}