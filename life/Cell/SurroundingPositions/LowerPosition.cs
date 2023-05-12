using Life.CellPosition;

namespace Life.CellSurroundingPositions;

public class LowerPosition : ISurroundingPosition
{
	public Position Get(Position position)
	{
		return new Position(position.X() + 1, position.Y());
	}
}