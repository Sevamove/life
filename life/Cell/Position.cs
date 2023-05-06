namespace Life
{
	public interface IPosition
	{
		public static abstract Position[] GetSurroundedCells(Position position);
		public int X();
		public int Y();
	}

	public class Position : IPosition
	{
		private const int SURROUNDED_POSITIONS_AMOUNT = 8;
		private readonly int x;
		private readonly int y;

		public Position(int x, int y)
		{
			this.x = x;
			this.y = y;
		}

		public static Position[] GetSurroundedCells(Position position)
		{
			Position[] positions = new Position[SURROUNDED_POSITIONS_AMOUNT];

			positions[0] = up(position);
			positions[1] = down(position);
			positions[2] = left(position);
			positions[3] = right(position);
			positions[4] = upLeft(position);
			positions[5] = upRight(position);
			positions[6] = downLeft(position);
			positions[7] = downRight(position);

			return positions;
		}

		public int X()
		{
			return this.x;
		}

		public int Y()
		{
			return this.y;
		}

		private static Position up(Position position)
		{
			return new Position(position.X() - 1, position.Y());
		}

		private static Position down(Position position)
		{
			return new Position(position.X() + 1, position.Y());
		}

		private static Position left(Position position)
		{
			return new Position(position.X(), position.Y() - 1);
		}

		private static Position right(Position position)
		{
			return new Position(position.X(), position.Y() + 1);
		}

		private static Position upLeft(Position position)
		{
			return new Position(position.X() - 1, position.Y() - 1);
		}

		private static Position upRight(Position position)
		{
			return new Position(position.X() - 1, position.Y() + 1);
		}

		private static Position downLeft(Position position)
		{
			return new Position(position.X() + 1, position.Y() - 1);
		}

		private static Position downRight(Position position)
		{
			return new Position(position.X() + 1, position.Y() + 1);
		}
	}
}