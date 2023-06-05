using Domain.Entities;
using Domain.Exceptions;
using Domain.ValueObjects.Cell;

namespace Test.Domain.Entities;

public class CellTest
{
	private readonly Cell liveCell;
	private readonly Cell deadCell;

	public CellTest()
	{
		this.liveCell = new Cell(new Position(1, 1), State.LIVE);
		this.deadCell = new Cell(new Position(2, 2), State.DEAD);
	}

	[Theory]
	[InlineData(0, State.DEAD)]
	[InlineData(1, State.DEAD)]
	[InlineData(2, State.LIVE)]
	[InlineData(3, State.LIVE)]
	[InlineData(4, State.DEAD)]
	[InlineData(5, State.DEAD)]
	[InlineData(6, State.DEAD)]
	[InlineData(7, State.DEAD)]
	[InlineData(8, State.DEAD)]
	public void SetState_CanSuccessfullySetStateForLiveCell(int neighborsAmount, State expectedState)
	{
		// Act.

		this.liveCell.SetState(neighborsAmount);
		State actualState = this.liveCell.GetState();

		// Assert.

		Assert.Equal(actualState, expectedState);
	}

	[Theory]
	[InlineData(0, State.DEAD)]
	[InlineData(1, State.DEAD)]
	[InlineData(2, State.DEAD)]
	[InlineData(3, State.LIVE)]
	[InlineData(4, State.DEAD)]
	[InlineData(5, State.DEAD)]
	[InlineData(6, State.DEAD)]
	[InlineData(7, State.DEAD)]
	[InlineData(8, State.DEAD)]
	public void SetState_CanSuccessfullySetStateForDeadCell(int neighborsAmount, State expectedState)
	{
		// Act.

		this.deadCell.SetState(neighborsAmount);
		State actualState = this.deadCell.GetState();

		// Assert.

		Assert.Equal(actualState, expectedState);
	}

	[Theory]
	[InlineData(-2)]
	[InlineData(-1)]
	[InlineData(9)]
	[InlineData(10)]
	[InlineData(11)]
	[InlineData(int.MinValue)]
	[InlineData(int.MaxValue)]
	public void SetState_ThrowException(int neighborsAmount)
	{
		// Act and Assert.

		Assert.Throws<InvalidNeighborsAmountException>(() => this.deadCell.SetState(neighborsAmount));
	}

	[Fact]
	public void GetPosition_ReturnsPosition()
	{
		// Arrange.

		Position liveCellExpectedPosition = new Position(1, 1);
		Position deadCellExpectedPosition = new Position(2, 2);

		// Act.

		Position liveCellActualPosition = this.liveCell.GetPosition();
		Position deadCellActualPosition = this.deadCell.GetPosition();

		// Assert.

		Assert.True(liveCellActualPosition.Equals(liveCellExpectedPosition));
		Assert.True(deadCellActualPosition.Equals(deadCellExpectedPosition));
	}

	[Fact]
	public void GetState_ReturnsState()
	{
		// Arrange.

		State liveCellExpectedState = State.LIVE;
		State deadCellExpectedState = State.DEAD;

		// Act.

		State liveCellActualState = this.liveCell.GetState();
		State deadCellActualState = this.deadCell.GetState();

		// Assert.

		Assert.Equal(liveCellActualState, liveCellExpectedState);
		Assert.Equal(deadCellActualState, deadCellExpectedState);
	}

	[Fact]
	public void GetState_ReturnsInteger()
	{
		// Arrange.

		int liveCellExpectedState = (int)State.LIVE;
		int deadCellExpectedState = (int)State.DEAD;

		// Act.

		int liveCellActualState = (int)this.liveCell.GetState();
		int deadCellActualState = (int)this.deadCell.GetState();

		// Assert.

		Assert.Equal(liveCellActualState, liveCellExpectedState);
		Assert.Equal(deadCellActualState, deadCellExpectedState);
	}

	[Fact]
	public void Clone_ReturnsObject()
	{
		// Arrange.

		Cell expectedLiveCell = new Cell(new Position(1, 1), State.LIVE);
		Cell expectedDeadCell = new Cell(new Position(2, 2), State.DEAD);

		// Act.

		Cell actualLiveCell = (Cell)this.liveCell.Clone();
		Cell actualDeadCell = (Cell)this.deadCell.Clone();

		// Assert.

		Assert.True(actualLiveCell.Equals(expectedLiveCell));
		Assert.True(actualDeadCell.Equals(expectedDeadCell));
	}

	[Fact]
	public void Equals_ReturnsTrue()
	{
		// Arrange.

		Cell expectedLiveCell = new Cell(new Position(1, 1), State.LIVE);
		Cell expectedDeadCell = new Cell(new Position(2, 2), State.DEAD);

		// Act.

		Cell actualLiveCell = (Cell)this.liveCell.Clone();
		Cell actualDeadCell = (Cell)this.deadCell.Clone();

		// Assert.

		Assert.True(actualLiveCell.Equals(expectedLiveCell));
		Assert.True(actualDeadCell.Equals(expectedDeadCell));
	}

	[Fact]
	public void Equals_ReturnsFalse()
	{
		// Arrange.

		Cell expectedLiveCell = new Cell(new Position(1, 1), State.LIVE);
		Cell expectedDeadCell = new Cell(new Position(2, 2), State.DEAD);

		// Act.

		Cell actualLiveCell = (Cell)this.liveCell.Clone();
		Cell actualDeadCell = (Cell)this.deadCell.Clone();

		// Assert.

		Assert.False(actualLiveCell.Equals(expectedDeadCell));
		Assert.False(actualDeadCell.Equals(expectedLiveCell));
	}
}
