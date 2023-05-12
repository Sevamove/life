using Life.CellPosition;
using Life.GridBorder;

namespace Life.CellSurroundingPositions;

public class SurroundingPositionsFactory
{
	public static ISurroundingPosition[] GetDefaultSurroundingPositions()
	{
		return getDefaultSurroundingPositions();
	}

	public static List<ISurroundingPosition> GetApplicableSurroundingPositions(Border border, Position position)
	{
		List<ISurroundingPosition> surroundingPositions = new List<ISurroundingPosition>();

		ISurroundingPosition[] defaultSurroundingPositions = getDefaultSurroundingPositions();

		foreach (var defaultSurroundingPosition in defaultSurroundingPositions)
		{
			if (!border.Is(defaultSurroundingPosition.Get(position)))
			{
				surroundingPositions.Add(defaultSurroundingPosition);
			}
		}

		return surroundingPositions;
	}

	private static ISurroundingPosition[] getDefaultSurroundingPositions()
	{
		ISurroundingPosition[] positions = new ISurroundingPosition[8] {
			new UpperPosition(),
			new UpperLeftPosition(),
			new UpperRightPosition(),
			new LowerPosition(),
			new LowerLeftPosition(),
			new LowerRightPosition(),
			new LeftPosition(),
			new RightPosition()
		};

		return positions;
	}
}