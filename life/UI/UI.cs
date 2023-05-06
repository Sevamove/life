namespace Life
{
	public interface IUI
	{
		public void Clear();
		public void Delay();
		public void Display(Cell[,] cells);
	}

	public class UI : IUI
	{
		private const string LIVE_CELL_ICON = "🟦";
		private const string DEAD_CELL_ICON = "🟨";
		private readonly Area area;
		private readonly int fps;

		public UI(int fps, Area area)
		{
			this.area = area;
			this.fps = fps;
		}

		public void Clear()
		{
			Console.Clear();
		}

		public void Delay()
		{
			int frameDelay = 1000 / this.fps;

			Thread.Sleep(frameDelay);
		}

		public void Display(Cell[,] cells)
		{
			for (int x = 0; x < this.area.Width; x++)
			{
				for (int y = 0; y < this.area.Height; y++)
				{
					bool isAliveCell = cells[x, y].GetState() == State.LIVE;

					Console.Write(isAliveCell ? LIVE_CELL_ICON : DEAD_CELL_ICON);
				}
				Console.WriteLine();
			}
			Console.WriteLine();
		}
	}
}