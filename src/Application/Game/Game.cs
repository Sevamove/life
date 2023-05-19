using Life.GamePatterns;
using Life.GridArea;

namespace Life;

public class Game
{
	public static void Play()
	{
		Area area = new Area(20, 20);
		UI ui = new UI(1, area);
		Grid grid = new Grid(area);

		grid.Initialize();

		Cell[] cells = PulsarPattern.GetCells();

		grid.Update(cells);

		while (true)
		{
			ui.Clear();
			ui.Display(grid.GetCells());
			ui.Delay();

			grid.Renew();
		}
	}
}