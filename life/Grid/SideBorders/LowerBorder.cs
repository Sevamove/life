using Life.CellPosition;
using Life.GridArea;

namespace Life.GridSideBorders;

public class LowerBorder : ISideBorder
{
	public bool Is(Area area, Position position)
	{
		return position.X() == area.Height ? true : false;
	}
}