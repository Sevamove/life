namespace test;

public class PositionTest
{
	private readonly Position position;

	public PositionTest()
	{
		this.position = new Position(10, 8);
	}

	[Fact]
	public void GetSurroundedCells_ShouldReturnEightPositions()
	{
		// Arrange.

		var expectedLength = 8;

		// Act.

		var actualLength = Position.GetSurroundedCells(this.position).Length;

		// Assert.

		Assert.Equal(expectedLength, actualLength);
	}

	[Fact]
	public void X_ReturnsX()
	{
		// Arrange.

		var expectedX = 10;

		// Act.

		var actualX = this.position.X();

		// Assert.

		Assert.Equal(expectedX, actualX);
	}

	[Fact]
	public void Y_ReturnsY()
	{
		// Arrange.

		var expectedY = 8;

		// Act.

		var actualY = this.position.Y();

		// Assert.

		Assert.Equal(expectedY, actualY);
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectUpperPosition()
	{
		// Arrange.

		Position expectedUp = new Position(this.position.X() - 1, this.position.Y());

		// Act.

		Position actualUp = Position.GetSurroundedCells(this.position)[0];

		// Assert.

		Assert.Equal(expectedUp.X(), actualUp.X());
		Assert.Equal(expectedUp.Y(), actualUp.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectLowerPosition()
	{
		// Arrange.

		Position expectedDown = new Position(this.position.X() + 1, this.position.Y());

		// Act.

		Position actualDown = Position.GetSurroundedCells(this.position)[1];

		// Assert.

		Assert.Equal(expectedDown.X(), actualDown.X());
		Assert.Equal(expectedDown.Y(), actualDown.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectLeftPosition()
	{
		// Arrange.

		Position expectedLeft = new Position(this.position.X(), this.position.Y() - 1);

		// Act.

		Position actualLeft = Position.GetSurroundedCells(this.position)[2];

		// Assert.

		Assert.Equal(expectedLeft.X(), actualLeft.X());
		Assert.Equal(expectedLeft.Y(), actualLeft.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectRightPosition()
	{
		// Arrange.

		Position expectedRight = new Position(this.position.X(), this.position.Y() + 1);

		// Act.

		Position actualRight = Position.GetSurroundedCells(this.position)[3];

		// Assert.

		Assert.Equal(expectedRight.X(), actualRight.X());
		Assert.Equal(expectedRight.Y(), actualRight.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectUpLeftPosition()
	{
		// Arrange.

		Position expectedUpLeft = new Position(this.position.X() - 1, this.position.Y() - 1);

		// Act.

		Position actualUpLeft = Position.GetSurroundedCells(this.position)[4];

		// Assert.

		Assert.Equal(expectedUpLeft.X(), actualUpLeft.X());
		Assert.Equal(expectedUpLeft.Y(), actualUpLeft.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectUpRightPosition()
	{
		// Arrange.

		Position expectedUpRight = new Position(this.position.X() - 1, this.position.Y() + 1);

		// Act.

		Position actualUpRight = Position.GetSurroundedCells(this.position)[5];

		// Assert.

		Assert.Equal(expectedUpRight.X(), actualUpRight.X());
		Assert.Equal(expectedUpRight.Y(), actualUpRight.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectDownLeftPosition()
	{
		// Arrange.

		Position expectedDownLeft = new Position(this.position.X() + 1, this.position.Y() - 1);

		// Act.

		Position actualDownLeft = Position.GetSurroundedCells(this.position)[6];

		// Assert.

		Assert.Equal(expectedDownLeft.X(), actualDownLeft.X());
		Assert.Equal(expectedDownLeft.Y(), actualDownLeft.Y());
	}

	[Fact]
	public void GetSurroundedCells_ReturnsCorrectDownRightPosition()
	{
		// Arrange.

		Position expectedDownRight = new Position(this.position.X() + 1, this.position.Y() + 1);

		// Act.

		Position actualDownRight = Position.GetSurroundedCells(this.position)[7];

		// Assert.

		Assert.Equal(expectedDownRight.X(), actualDownRight.X());
		Assert.Equal(expectedDownRight.Y(), actualDownRight.Y());
	}
}