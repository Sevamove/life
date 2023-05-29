using Domain.DTO;

namespace UI.Console.Converters;

// TODO: get rid of technical debt.
public class DTOConverter
{
	public static GameDTO? ConvertToGameDTO(string gameId, string gameName, string gridArea, string[] gridCells)
	{
		GridDTO? grid = ConvertToGridDTO(gridArea, gridCells);

		System.Console.WriteLine("Converted grid");

		if (grid == null)
		{
			System.Console.WriteLine("grid is null");
			return null;
		}

		return new GameDTO(gameId, gameName, grid);
	}

	public static GridDTO? ConvertToGridDTO(string gridArea, string[] gridCells)
	{
		AreaDTO? area = ConvertToAreaDTO(gridArea);

		if (area == null)
		{
			return null;
		}

		CellDTO[,]? cells = ConvertToCellDTOs(area, gridCells);

		if (cells == null)
		{
			return null;
		}

		return new GridDTO(area, cells);
	}

	public static AreaDTO? ConvertToAreaDTO(string gridArea)
	{
		string[] area = gridArea.Split("-");

		int width = -1;
		int height = -1;

		bool success = int.TryParse(area[0], out width);

		if (!success)
		{
			return null;
		}

		success = int.TryParse(area[1], out height);

		if (!success)
		{
			return null;
		}

		return new AreaDTO(width, height);

	}

	public static CellDTO[,] ConvertToCellDTOs(AreaDTO gridArea, string[] gridCells)
	{
		CellDTO[,] cells = new CellDTO[gridArea.Width, gridArea.Height];

		for (int x = 0; x < gridArea.Width; x++)
		{
			for (int y = 0; y < gridArea.Height; y++)
			{
				cells[x, y] = new CellDTO("1", new PositionDTO(x, y), 0);
			}
		}

		for (int i = 0; i < gridCells.Length; i++)
		{
			CellDTO cell = ConvertToCellDTO(gridCells[i]);
			cells[cell.Position.X, cell.Position.Y] = cell;
		}

		return cells;
	}

	// Cell position 15-10
	public static CellDTO? ConvertToCellDTO(string cell)
	{
		PositionDTO? position = ConvertToPositionDTO(cell);

		if (position == null)
		{
			return null;
		}

		return new CellDTO("1", position, 1);
	}

	public static PositionDTO? ConvertToPositionDTO(string cell)
	{
		string[] position = cell.Split("-");

		int x = -1;
		int y = -1;

		bool success = int.TryParse(position[0], out x);

		if (!success)
		{
			return null;
		}

		success = int.TryParse(position[1], out y);

		if (!success)
		{
			return null;
		}

		return new PositionDTO(x, y);
	}
}