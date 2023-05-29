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

	public async Task<GameDTO?> GetGame(string id)
	{
		return await this.gameController.GetGame(id);
	}

	public async Task<GameDTO[]?> GetGames()
	{
		return await this.gameController.GetGames();
	}

	public async Task<GameDTO> GetGrid(GameDTO game)
	{
		return await this.gridController.GetGrid(game);
	}

	public async Task<GameDTO> PostGame(GameDTO game)
	{
		return await this.gameController.PostGame(game);
	}

	public async Task<GameDTO> PutGame(GameDTO game)
	{
		return await this.gameController.PutGame(game);
	}
}