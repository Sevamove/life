using Domain.Interfaces;

namespace Domain.Aggregates;

public class Game : IGame
{
	private string id;
	private string name;
	private IGrid grid;

	public Game(string id, string name, IGrid grid)
	{
		this.id = id;
		this.name = name;
		this.grid = grid;
	}

	public IGrid Grid()
	{
		return this.grid;
	}

	public string Id()
	{
		return this.id;
	}

	public string Name()
	{
		return this.name;
	}

	public void SetGrid(IGrid grid)
	{
		this.grid = grid;
	}

	public void SetId(string id)
	{
		this.id = id;
	}

	public void SetName(string name)
	{
		this.name = name;
	}
}