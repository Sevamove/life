using Life.CellPosition;
using Life.CellState;

namespace Life.GamePatterns;

public static class BlinkerPattern
{
	private static readonly Cell[] cells = new Cell[] {
			new Cell(new Position(1, 2), State.LIVE),
			new Cell(new Position(2, 2), State.LIVE),
			new Cell(new Position(3, 2), State.LIVE),
		};

	public static Cell[] GetCells()
	{
		return cells;
	}
}