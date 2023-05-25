using Domain.DTO;

namespace Application.Interfaces;

public interface IGameService
{
	public Task<GameDTO> CreateNewGame(GameDTO game);
	public void DeleteGame(GameDTO game);
	public Task<GameDTO?> LoadGame(string id);
	public Task<GameDTO[]?> LoadGames();
	public Task<GameDTO> SaveGame(GameDTO game);
	public Task<GameDTO> UpdateGame(GameDTO game);
}