

namespace Life.Patterns
{
	public static class Glider
	{
		private static readonly Cell[] cells = new Cell[] {
			new Cell(new Position(0, 1), State.LIVE),
			new Cell(new Position(1, 2), State.LIVE),
			new Cell(new Position(2, 0), State.LIVE),
			new Cell(new Position(2, 1), State.LIVE),
			new Cell(new Position(2, 2), State.LIVE),
		};

		public static Cell[] GetCells()
		{
			return cells;
		}
	}
}