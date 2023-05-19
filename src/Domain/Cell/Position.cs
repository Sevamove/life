namespace Life.CellPosition;

public interface IPosition
{
	// Read methods.

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
}