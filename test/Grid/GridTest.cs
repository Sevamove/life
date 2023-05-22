using Domain.GridArea;

namespace test;

public class GridTest
{
	private readonly Area area = new Area(20, 20);
	private Grid grid;

	public GridTest()
	{
		this.grid = new Grid(this.area);
		this.grid.Update(PulsarPattern.GetCells());
	}

	[Theory]
	[InlineData(0, 0)]
	[InlineData(1, 1)]
	[InlineData(2, 2)]
	[InlineData(5, 19)]
	public void Initialze_CanSuccessfullyInitializeGrid(int x, int y)
	{
		// Arrange.

		Position position = new Position(x, y);
		Cell expectedCell = new Cell(position, State.DEAD);

		// Act.

		this.grid.Initialize();
		Cell actualCell = this.grid.GetCell(position);

		// Assert.

		Assert.True(actualCell.Equals(expectedCell));
	}

	// TODO: finish.
	// [Fact]
	// public void Renew()
	// {
	// 	// Arrange.

	// 	Cell[,] oldCells = this.grid.GetCells();

	// 	// Act.

	// 	this.grid.Renew();
	// 	Cell[,] newCells = this.grid.GetCells();

	// 	// Assert.

	// 	Cell oldCell = oldCells[0, 0];
	// 	Cell newCell = newCells[1, 1];

	// 	Assert.False(oldCell.Equals(newCell));

	// }

	public void Update() { }

	public void GetCell() { }

	public void GetCells() { }
}