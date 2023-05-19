using Life.CellPosition;

namespace Life.CellSurroundingPositions;

public interface ISurroundingPosition
{
	public Position Get(Position position);
}