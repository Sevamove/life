using Infrastructure.DTO;

namespace UI.Console.Events;

public class GamesEventSubscriber
{
	private GameDTO[] fetchedGames;

	// Event handler method
	public void UpdateFetchedGames(GameDTO[] games)
	{
		this.fetchedGames = games;
		System.Console.WriteLine("Event handled: " + games);
	}

	public GameDTO[] GetFetchedGames()
	{
		return this.fetchedGames;
	}
}