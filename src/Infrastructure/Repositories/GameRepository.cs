using Infrastructure.Adapters;
using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public class GameRepository : IRepository<GameEntity>
{
	private IRepository<GameEntity> dbClient;

	// public GameRepository(IRepository<GameEntity> dbClient)
	// {
	// 	this.dbClient = dbClient;
	// }

	public GameRepository()
	{
		this.dbClient = new JsonFileAdapter<GameEntity>(Config.DB_URL);
	}

	public Task<GameEntity?> FindByIdAsync<GameEntity>(string id) where GameEntity : BaseEntity
	{
		return this.dbClient.FindByIdAsync<GameEntity>(id);
	}

	public void SaveAllAsync(List<GameEntity> data)
	{
		this.dbClient.SaveAllAsync(data);
	}

	public Task<List<GameEntity>?> FindAllAsync()
	{
		return this.dbClient.FindAllAsync();
	}
}