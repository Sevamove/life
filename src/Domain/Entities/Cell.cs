using Domain.Exceptions;
using Domain.ValueObjects.Cell;

namespace Domain.Entities;

/// TODO
public interface ICell : ICloneable
{
	/// <summary>Set `state` for cell.</summary>
	/// <param name="neighborsAmount">Amount of neighbors of cell.</param>
	public void SetState(int neighborsAmount);
	// TODO
	public Position GetPosition();
	// TODO
	public State GetState();
}

/// TODO
public class Cell : ICell
{
	/// TODO
	private Position position;
	/// TODO
	private State state;

	/// TODO
	public Cell(Position position, State state)
	{
		this.position = position;
		this.state = state;
	}

	/// <inheritdoc /> 
	public void SetState(int neighborsAmount)
	{
		this.validateNeighborsAmount(neighborsAmount);

		if (this.shouldLive(neighborsAmount) || this.shouldBorn(neighborsAmount))
		{
			this.state = State.LIVE;
			return;
		}

		// if (this.shouldDie(neighborsAmount))
		// {
		// 	this.state = State.DEAD;
		// }
		this.state = State.DEAD;
	}

	/// <inheritdoc /> 
	public Position GetPosition()
	{
		return this.position;
	}

	/// <inheritdoc /> 
	public State GetState()
	{
		return this.state;
	}

	/// <inheritdoc /> 
	public object Clone()
	{
		return new Cell(this.position, this.state);
	}

	// TODO: make it better.
	// override object.Equals
	public override bool Equals(object obj)
	{
		if (obj == null || GetType() != obj.GetType())
		{
			return false;
		}

		Cell cell = (Cell)obj;

		if (cell.GetPosition().X() != this.position.X() || cell.GetPosition().Y() != this.position.Y())
		{
			return false;
		}

		if (cell.GetState() != this.state)
		{
			return false;
		}

		return true;
	}

	public override int GetHashCode()
	{
		throw new NotImplementedException();
	}

	private void validateNeighborsAmount(int neighborsAmount)
	{
		int minimumNeighborsAmountAllowed = 0;
		int maximumNeighborsAmountAllowed = 8;

		if (neighborsAmount < minimumNeighborsAmountAllowed || neighborsAmount > maximumNeighborsAmountAllowed)
		{
			throw new InvalidNeighborsAmountException();
		}
	}

	/// TODO
	private bool shouldLive(int neighborsAmount)
	{
		bool isAlive = this.state == State.LIVE;
		bool shouldRemainAlive = neighborsAmount == 2 || neighborsAmount == 3;

		if (isAlive && shouldRemainAlive)
		{
			return true;
		}

		return false;
	}

	/// TODO
	private bool shouldBorn(int neighborsAmount)
	{
		bool isDead = this.state == State.DEAD;
		bool shouldBeReproduced = neighborsAmount == 3;

		if (isDead && shouldBeReproduced)
		{
			return true;
		}

		return false;
	}

	/// TODO
	private bool shouldDie(int neighborsAmount)
	{
		bool isUnderpopulated = neighborsAmount < 2;
		bool isOverpopulated = neighborsAmount > 3;

		if (isUnderpopulated || isOverpopulated)
		{
			return true;
		}

		return false;
	}
}