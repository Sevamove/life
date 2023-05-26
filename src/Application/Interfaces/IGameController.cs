using Domain.DTO;

namespace Application.Interfaces;

public interface IGameController
{
	public Task<GameDTO> PostGame(GameDTO game); // Creates a new game.
	public Task<GameDTO> PutGame(GameDTO game); // Updates and saves the game.
	public Task<GameDTO?> GetGame(string id); // Fetches a game of `id` from DB.
	public Task<GameDTO[]?> GetGames(); // Fetches all games from DB.
	public bool DeleteGame(GameDTO game); // Removes the game from DB.
}