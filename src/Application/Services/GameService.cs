using Application.Interfaces;
using Domain.DTO;
using Infrastructure.Builders.DTO;
using Infrastructure.Builders.Entities;
using Infrastructure.Entities;
using Infrastructure.Interfaces;

namespace Application.Services;

public class GameService : IGameService
{
	private readonly IRepository<GameEntity> gameRepository;

	public GameService(IRepository<GameEntity> repository)
	{
		this.gameRepository = repository;
	}

	public async Task<GameDTO> CreateNewGame(GameDTO game)
	{
		List<GameEntity> gameEntities = new List<GameEntity>() {
			GameEntityBuilder.GetGameEntity(game)};

		List<GameEntity> savedGameEntities = await this.gameRepository.SaveAllAsync(gameEntities);

		return GameDTOBuilder.GetGameDTO(savedGameEntities.ToArray()[0]);
	}

	public void DeleteGame(GameDTO game)
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

	public async Task<GameDTO[]?> LoadGames()
	{
		List<GameEntity>? data = await this.gameRepository.FindAllAsync();

		if (data != null)
		{
			return GameDTOBuilder.GetGameDTOs(data);
		}

		return null;
	}

	public Task<GameDTO> SaveGame(GameDTO game)
	{
		throw new NotImplementedException();
	}

	public Task<GameDTO> UpdateGame(GameDTO game)
	{
		throw new NotImplementedException();
	}
}