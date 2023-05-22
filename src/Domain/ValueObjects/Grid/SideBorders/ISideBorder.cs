using Domain.ValueObjects.Cell;

namespace Domain.ValueObjects.Grid.SideBorders;

public interface ISideBorder
{
	public bool Is(Area area, Position position);
}