using Domain.DTO;

namespace Application.Interfaces;

public interface IGameService
{
	public Task<GameDTO> PostGame(GameDTO game);
	public bool DeleteGame(GameDTO game);
	public Task<GameDTO?> GetGame(string id);
	public Task<GameDTO[]?> GetGames();
	public Task<GameDTO> PutGame(GameDTO game);
	public Task<GameDTO> UpdateGame(GameDTO game);
}