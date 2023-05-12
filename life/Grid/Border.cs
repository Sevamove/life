
using Life.CellPosition;
using Life.GridArea;
using Life.GridSideBorders;

namespace Life.GridBorder;

interface IBorder
{
	// Read methods.

	public bool Is(Position position);
	public bool Is(List<ISideBorder> sideBorder, Position position);
}

public class Border : IBorder
{
	private readonly Area area;

	public Border(Area area)
	{
		this.area = area;
	}

	public bool Is(Position position)
	{
		List<ISideBorder> sideBorders = SideBordersFactory.GetAllSideBorders();

		return this.isBorder(sideBorders, position);
	}

	public bool Is(List<ISideBorder> sideBorders, Position position)
	{
		return this.isBorder(sideBorders, position);
	}

	private bool isBorder(List<ISideBorder> sideBorders, Position position)
	{
		foreach (var sideBorder in sideBorders)
		{
			if (sideBorder.Is(this.area, position))
			{
				return true;
			}
		}

		return false;
	}
}