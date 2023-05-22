using Infrastructure.Entities;

namespace Infrastructure.Repositories;

public interface IRepository<T>
{
	// Create methods.
	public void SaveAllAsync(List<T> data);
	// Read methods.
	public Task<T?> FindByIdAsync<T>(string id) where T : BaseEntity;
	public Task<List<T>?> FindAllAsync();
	// Update methods.
	//public Task UpdateByIdAsync(U id, T data);
	// Delete methods.
	//public void DeleteByIdAsync(U id);
	//public void DeleteAllAsync();
}