using Application.Interfaces;
using Domain.DTO;

namespace Application;

public class RestApi : IRestApi
{
	private readonly GameController gameController = new GameController();
	private readonly GridController gridController = new GridController();

	public bool DeleteGame(GameDTO game)
	{
		return this.gameController.DeleteGame(game);
	}

	public Task<GameDTO?> GetGame(string id)
	{
		return this.gameController.GetGame(id);
	}

	public Task<GameDTO[]?> GetGames()
	{
		return this.gameController.GetGames();
	}

	public async Task<GameDTO> GetGrid(GameDTO game)
	{
		return await this.gridController.GetGrid(game);
	}

	public Task<GameDTO> PostGame(GameDTO game)
	{
		return this.gameController.PostGame(game);
	}

	public Task<GameDTO> PutGame(GameDTO game)
	{
		return this.gameController.PutGame(game);
	}
}