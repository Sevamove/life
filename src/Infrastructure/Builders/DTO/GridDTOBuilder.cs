using Domain.DTO;
using Domain.Entities;
using Domain.Interfaces;
using Domain.ValueObjects.Cell;
using Domain.ValueObjects.Grid;
using Infrastructure.Entities;

namespace Infrastructure.Builders.DTO;

public class GridDTOBuilder
{
	public static GridDTO GetGridDTO(GridEntity gridEntity)
	{
		AreaEntity area = gridEntity.Area;
		CellDTO[,] cells = new CellDTO[area.Width, area.Height];

		for (int x = 0; x < area.Width; x++)
		{
			for (int y = 0; y < area.Height; y++)
			{
				CellEntity cell = gridEntity.Cells[x, y];
				PositionDTO position = new PositionDTO(cell.Position.X, cell.Position.Y);
				int state = cell.State;

				cells[x, y] = new CellDTO(x.ToString() + y.ToString(), position, state);
			}
		}

		return new GridDTO(new AreaDTO(area.Width, area.Height), cells);
	}

	public static GridDTO GetGridDTO(IGrid grid)
	{
		Area area = grid.GetArea();
		CellDTO[,] cells = new CellDTO[grid.GetArea().Width, grid.GetArea().Height];

		for (int x = 0; x < area.Width; x++)
		{
			for (int y = 0; y < area.Height; y++)
			{
				// TODO: Make this code simpler.
				Cell cell = (Cell)grid.GetCell(new Position(x, y)).Clone();
				PositionDTO position = new PositionDTO(cell.GetPosition().X(), cell.GetPosition().Y());
				int state = (int)cell.GetState();

				cells[x, y] = new CellDTO(x.ToString() + y.ToString(), position, state);
			}
		}

		return new GridDTO(new AreaDTO(area.Width, area.Height), cells);
	}
}