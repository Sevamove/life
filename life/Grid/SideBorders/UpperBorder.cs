using Life.CellPosition;
using Life.GridArea;

namespace Life.GridSideBorders;

public class UpperBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.X() == (area.Height - area.Height) - 1 ? true : false;
	}
}