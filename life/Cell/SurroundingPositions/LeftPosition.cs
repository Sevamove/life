using Life.CellPosition;

namespace Life.CellSurroundingPositions;

public class LeftPosition : ISurroundingPosition
{
	public Position Get(Position position)
	{
		return new Position(position.X(), position.Y() - 1);
	}
}