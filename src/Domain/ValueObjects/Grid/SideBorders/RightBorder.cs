using Life.CellPosition;
using Life.GridArea;

namespace Life.GridSideBorders;

public class RightBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.Y() == area.Width ? true : false;
	}
}