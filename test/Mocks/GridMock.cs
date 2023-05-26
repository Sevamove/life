using Domain.Aggregates;
using Domain.Entities;
using Domain.ValueObjects.Cell;
using Domain.ValueObjects.Grid;

public class GridMock : Grid
{
	public GridMock(Area area) : base(area)
	{
		this.updateGrid();
	}

	public GridMock() : base(new Area(20, 20))
	{
		base.Initialize();
		this.updateGrid();
	}

	private void updateGrid()
	{
		Cell[] cells = new Cell[] {
			new Cell(new Position(10,10), State.LIVE),
			new Cell(new Position(10,11), State.LIVE),
			new Cell(new Position(10,12), State.LIVE),
		};

		base.Update(cells);
	}
}