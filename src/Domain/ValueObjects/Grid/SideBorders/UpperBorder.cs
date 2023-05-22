using Domain.ValueObjects.Cell;

namespace Domain.ValueObjects.Grid.SideBorders;

public class UpperBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.X() == (area.Height - area.Height) - 1 ? true : false;
	}
}