using Infrastructure;
using Infrastructure.Adapters;
using Infrastructure.DTO;
using Infrastructure.DTO.Builders;
using Infrastructure.Entities;
using Infrastructure.Entities.Builders;
using Infrastructure.Repositories;

namespace Application;

public interface IGame
{
	// Create a new game.
	public GameDTO CreateNewGame(GameDTO game);
	// Save a played game to DB.
	public bool SaveGrid();
	// Load a game from the DB.
	public Task<GameDTO?> LoadGame(string id);
	public GameDTO[] LoadGames();
	// Update the grid and return an updated version.
	public void UpdateGame();
	// Delete a game in DB.
	public bool DeleteGame(GridDTO grid);
}

// TODO: Create service class for the controller.
public class Game : IGame
{
	// public static void Play()
	// {
	// 	Area area = new Area(20, 20);
	// 	UI ui = new UI(1, area);
	// 	Grid grid = new Grid(area);

	// 	grid.Initialize();

	// 	Cell[] cells = PulsarPattern.GetCells();

	// 	grid.Update(cells);

	// 	while (true)
	// 	{
	// 		ui.Clear();
	// 		ui.Display(grid.GetCells());
	// 		ui.Delay();

	// 		grid.Renew();
	// 	}
	// }

	// TODO: replace GameRepository with the interface.
	private readonly GameRepository gameRepository;

	public Game()
	{
		this.gameRepository = new GameRepository();
	}

	public GameDTO CreateNewGame(GameDTO game)
	{
		List<GameEntity> gameEntities = new List<GameEntity>() {
			GameEntityBuilder.GetGameEntity(game)};

		this.gameRepository.SaveAllAsync(gameEntities);

		return game;
	}

	public bool DeleteGame(GridDTO grid)
	{
		throw new NotImplementedException();
	}

	public async Task<GameDTO?> LoadGame(string id)
	{
		GameEntity? game = await this.gameRepository.FindByIdAsync<GameEntity>(id);

		if (game != null)
		{
			return GameDTOBuilder.GetGameDTO(game);
		}

		return null;
	}

	public GameDTO[] LoadGames()
	{
		throw new NotImplementedException();
	}

	public bool SaveGrid()
	{
		throw new NotImplementedException();
	}

	public void UpdateGame()
	{
		throw new NotImplementedException();
	}
}