using Domain.DTO;

namespace Application.Interfaces;

public interface IGameController
{
	public Task<GameDTO> CreateNewGame(GameDTO game);
	public Task<GameDTO> SaveGame(GameDTO game);
	public Task<GameDTO?> LoadGame(string id);
	public Task<GameDTO[]?> LoadGames();
	public Task<GameDTO> UpdateGame(GameDTO game);
	public bool DeleteGame(GridDTO grid);
}