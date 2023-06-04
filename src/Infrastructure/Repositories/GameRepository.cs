using Configuration;
using Infrastructure.Adapters;
using Infrastructure.Entities;
using Infrastructure.Interfaces;

namespace Infrastructure.Repositories;

public class GameRepository : IRepository<GameEntity>
{
	private IRepository<GameEntity> dbClient;

	public GameRepository()
	{
		this.dbClient = new JsonFileAdapter<GameEntity>(Config.GetDbUrls()["games"]);
	}

	public async Task<GameEntity?> FindByIdAsync(string id)
	{
		return await this.dbClient.FindByIdAsync(id);
	}

	public async Task<List<GameEntity>> SaveAllAsync(List<GameEntity> data)
	{
		return await this.dbClient.SaveAllAsync(data);
	}

	public async Task<List<GameEntity>?> FindAllAsync()
	{
		return await this.dbClient.FindAllAsync();
	}
}