namespace Domain.Interfaces;

public interface IGame
{
	// Write methods.

	public void SetId(string id);
	public void SetName(string name);
	public void SetGrid(IGrid grid);

	// Read methods.

	public string Id();
	public string Name();
	public IGrid Grid();
}