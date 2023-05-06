namespace Life
{
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
			if (this.shouldLive(neighborsAmount) || this.shouldBorn(neighborsAmount))
			{
				this.state = State.LIVE;
			}

			if (this.shouldDie(neighborsAmount))
			{
				this.state = State.DEAD;
			}
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
}