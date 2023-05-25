// using Infrastructure.Entities;

// namespace Infrastructure.Repositories;

// public class PatternRepository : IRepository<PatternEntity>
// {
// 	private IRepository<PatternEntity> dbClient;

// 	public PatternRepository(IRepository<PatternEntity> dbClient)
// 	{
// 		this.dbClient = dbClient;
// 	}

// 	public async Task<List<PatternEntity>?> FindAllAsync()
// 	{
// 		return await dbClient.FindAllAsync();
// 	}

// 	public async Task<T?> FindByIdAsync<T>(string id) where T : BaseEntity
// 	{
// 		return await dbClient.FindByIdAsync<T>(id);
// 	}

// 	public void SaveAllAsync(List<PatternEntity> data)
// 	{
// 		dbClient.SaveAllAsync(data);
// 	}
// }