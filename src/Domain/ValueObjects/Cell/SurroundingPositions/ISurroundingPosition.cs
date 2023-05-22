namespace Domain.ValueObjects.Cell.SurroundingPositions;

public interface ISurroundingPosition
{
	public Position Get(Position position);
}