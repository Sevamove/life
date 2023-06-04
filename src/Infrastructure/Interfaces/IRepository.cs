namespace Infrastructure.Interfaces;

public interface IRepository<T>
{
	// Create methods.
	public Task<List<T>> SaveAllAsync(List<T> data);
	// Read methods.
	public Task<T?> FindByIdAsync(string id);
	public Task<List<T>?> FindAllAsync();
	// Update methods.
	//public Task UpdateByIdAsync(U id, T data);
	// Delete methods.
	//public void DeleteByIdAsync(U id);
	//public void DeleteAllAsync();
}