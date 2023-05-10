namespace Life
{
	public interface IPosition
	{
		// Read methods.

		public Position[] GetSurroundedCells();
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

		public Position[] GetSurroundedCells()
		{
			Position[] positions = new Position[SURROUNDED_POSITIONS_AMOUNT];

			positions[0] = up();
			positions[1] = down();
			positions[2] = left();
			positions[3] = right();
			positions[4] = upLeft();
			positions[5] = upRight();
			positions[6] = downLeft();
			positions[7] = downRight();

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

		// override object.Equals
		public override bool Equals(object obj)
		{
			if (obj == null || GetType() != obj.GetType())
			{
				return false;
			}

			Position position = (Position)obj;

			if (position.X() != this.x || position.Y() != this.y)
			{
				return false;
			}

			return true;
		}

		// override object.GetHashCode
		public override int GetHashCode()
		{
			// TODO: write your implementation of GetHashCode() here
			throw new System.NotImplementedException();
			return base.GetHashCode();
		}

		private Position up()
		{
			return new Position(this.x - 1, this.y);
		}

		private Position down()
		{
			return new Position(this.x + 1, this.y);
		}

		private Position left()
		{
			return new Position(this.x, this.y - 1);
		}

		private Position right()
		{
			return new Position(this.x, this.y + 1);
		}

		private Position upLeft()
		{
			return new Position(this.x - 1, this.y - 1);
		}

		private Position upRight()
		{
			return new Position(this.x - 1, this.y + 1);
		}

		private Position downLeft()
		{
			return new Position(this.x + 1, this.y - 1);
		}

		private Position downRight()
		{
			return new Position(this.x + 1, this.y + 1);
		}
	}
}