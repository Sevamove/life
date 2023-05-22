using Domain.ValueObjects.Cell;

namespace Domain.ValueObjects.Grid.SideBorders;

public class RightBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.Y() == area.Width ? true : false;
	}
}