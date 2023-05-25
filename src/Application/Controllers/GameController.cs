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

	public async Task<GameDTO> CreateNewGame(GameDTO game)
	{
		return await this.gameService.CreateNewGame(game);
	}

	public void DeleteGame(GameDTO game)
	{
		this.gameService.DeleteGame(game);
	}

	public bool DeleteGame(GridDTO grid)
	{
		throw new NotImplementedException();
	}

	public async Task<GameDTO?> LoadGame(string id)
	{
		return await this.gameService.LoadGame(id);
	}

	public async Task<GameDTO[]?> LoadGames()
	{
		return await this.gameService.LoadGames();
	}

	public async Task<GameDTO> SaveGame(GameDTO game)
	{
		return await this.gameService.SaveGame(game);
	}

	public void UpdateGame()
	{
		throw new NotImplementedException();
	}

	public Task<GameDTO> UpdateGame(GameDTO game)
	{
		throw new NotImplementedException();
	}
}