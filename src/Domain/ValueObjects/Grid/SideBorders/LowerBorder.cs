using Domain.ValueObjects.Cell;

namespace Domain.ValueObjects.Grid.SideBorders;

public class LowerBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.X() == area.Height ? true : false;
	}
}