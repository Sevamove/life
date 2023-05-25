using Domain.Aggregates;
using Domain.Interfaces;

namespace Test.Mocks;

public class GameMock : Game
{
	public GameMock(string id, string name, IGrid grid) : base(id, name, grid) { }
	public GameMock(string id, string name) : base(id, name, new GridMock()) { }
	public GameMock(string id) : base(id, "My Game", new GridMock()) { }
	public GameMock() : base("1234567890", "My Game", new GridMock()) { }
}