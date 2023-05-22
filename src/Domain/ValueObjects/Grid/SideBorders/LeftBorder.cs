using Domain.ValueObjects.Cell;

namespace Domain.ValueObjects.Grid.SideBorders;

public class LeftBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.Y() == (area.Width - area.Width) - 1 ? true : false;
	}
}