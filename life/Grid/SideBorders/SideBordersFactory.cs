namespace Life.GridSideBorders;

public class SideBordersFactory
{
	public static List<ISideBorder> GetAllSideBorders()
	{
		return new List<ISideBorder>()
			{
				new UpperBorder(),
				new LowerBorder(),
				new LeftBorder(),
				new RightBorder()
			};
	}
}