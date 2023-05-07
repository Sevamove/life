namespace Life.Patterns
{
	public static class Toad
	{
		private static readonly Cell[] cells = new Cell[] {
			new Cell(new Position(2, 2), State.LIVE),
			new Cell(new Position(3, 2), State.LIVE),
			new Cell(new Position(4, 2), State.LIVE),
			new Cell(new Position(1, 3), State.LIVE),
			new Cell(new Position(2, 3), State.LIVE),
			new Cell(new Position(3, 3), State.LIVE),
		};

		public static Cell[] GetCells()
		{
			return cells;
		}
	}
}