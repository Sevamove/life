namespace Life.Patterns
{
	public static class Blinker
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
}