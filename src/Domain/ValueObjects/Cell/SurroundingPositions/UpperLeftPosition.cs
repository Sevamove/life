namespace Domain.ValueObjects.Cell.SurroundingPositions;

public class UpperLeftPosition : ISurroundingPosition
{
	public Position Get(Position position)
	{
		return new Position(position.X() - 1, position.Y() - 1);
	}
}