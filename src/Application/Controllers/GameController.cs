using Domain.DTO;
using Infrastructure.Repositories;
using Application.Interfaces;
using Application.Services;

namespace Application;

// TODO: Create service class for the controller.
public class GameController : IGameController
{
	private readonly IGameService gameService;

	public GameController()
	{
		this.gameService = new GameService(new GameRepository());
	}

	public async Task<GameDTO> PostGame(GameDTO game)
	{
		return await this.gameService.PostGame(game);
	}

	public bool DeleteGame(GameDTO game)
	{
		return this.gameService.DeleteGame(game);
	}

	public async Task<GameDTO?> GetGame(string id)
	{
		return await this.gameService.GetGame(id);
	}

	public async Task<GameDTO[]?> GetGames()
	{
		return await this.gameService.GetGames();
	}

	public async Task<GameDTO> PutGame(GameDTO game)
	{
		return await this.gameService.PutGame(game);
	}
}