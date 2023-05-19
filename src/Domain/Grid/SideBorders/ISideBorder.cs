using Life.CellPosition;
using Life.GridArea;

namespace Life.GridSideBorders;

public interface ISideBorder
{
	public bool Is(Area area, Position position);
}