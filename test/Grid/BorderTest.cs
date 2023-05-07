namespace test;

public class BorderTest
{
	private readonly Area area;
	private readonly Border border;

	public BorderTest()
	{
		Area area = new Area(20, 20);

		this.area = area;
		this.border = new Border(area);
	}

	[Theory]
	[InlineData(-1, 0, true)]
	[InlineData(20, 0, true)]
	[InlineData(0, 20, true)]
	[InlineData(0, -1, true)]
	public void IsAt_ReturnsTrue(int x, int y, bool isExpectedBorder)
	{
		// Arrange.

		Position position = new Position(x, y);

		// Act.

		bool isActualBorder = this.border.IsAt(position);

		// Assert.

		Assert.True(isActualBorder == isExpectedBorder);
	}

	[Theory]
	[InlineData(5, 0, false)]
	[InlineData(12, 4, false)]
	[InlineData(4, 9, false)]
	[InlineData(1, 1, false)]
	public void IsAt_ReturnsFalse(int x, int y, bool isExpectedBorder)
	{
		// Arrange.

		Position position = new Position(x, y);

		// Act.

		bool isActualBorder = this.border.IsAt(position);

		// Assert.

		Assert.True(isActualBorder == isExpectedBorder);
	}
}