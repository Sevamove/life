using Domain.DTO;
using Infrastructure.Entities;

namespace Infrastructure.Builders.Entities;

public class GridEntityBuilder
{
	// TODO: refactor. You repeat yourself in many functions where you have to loop through the grid.
	public static GridEntity GetGridEntity(GameDTO gameDTO)
	{
		AreaEntity area = new AreaEntity { Width = gameDTO.Grid.Area.Width, Height = gameDTO.Grid.Area.Height };
		CellEntity[,] cells = new CellEntity[area.Width, area.Height];

		for (int x = 0; x < area.Width; x++)
		{
			for (int y = 0; y < area.Height; y++)
			{
				CellDTO cellDTO = gameDTO.Grid.Cells[x, y];

				PositionEntity position = new PositionEntity
				{
					X = cellDTO.Position.X,
					Y = cellDTO.Position.Y
				};

				cells[x, y] = new CellEntity
				{
					Id = cellDTO.Id,
					Position = position,
					State = cellDTO.State
				};
			}
		}

		return new GridEntity { Area = area, Cells = cells };
	}
}