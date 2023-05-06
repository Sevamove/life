namespace Life
{
	interface IBorder
	{
		// Read methods.

		public bool IsAt(Position position);
	}

	public class Border : IBorder
	{
		private readonly Area area;

		public Border(Area area)
		{
			this.area = area;
		}

		public bool IsAt(Position position)
		{
			bool isUpper = this.isUpper(position);
			bool isLower = this.isLower(position);
			bool isLeft = this.isLeft(position);
			bool isRight = this.isRight(position);

			return (isUpper || isLower || isLeft || isRight);
		}

		private bool isUpper(Position position)
		{
			return position.X() == -1 ? true : false;
		}

		private bool isLower(Position position)
		{
			return position.X() == this.area.Height ? true : false;
		}

		private bool isLeft(Position position)
		{
			return position.Y() == -1 ? true : false;
		}

		private bool isRight(Position position)
		{
			return position.Y() == this.area.Width ? true : false;
		}
	}
}