using Infrastructure.Entities;

namespace Infrastructure.DTO.Builders;

public class GridDTOBuilder
{
	public static GridDTO GetGridDTO(GridEntity gridEntity)
	{
		CellDTO[] cellDTOs = new CellDTO[gridEntity.Cells.Length];

		foreach (var cellEntity in gridEntity.Cells)
		{
			PositionDTO positionDTO = new PositionDTO(cellEntity.Position.X, cellEntity.Position.Y);

			cellDTOs.Append(new CellDTO(cellEntity.Id, positionDTO, cellEntity.State));
		}

		return new GridDTO(new AreaDTO(gridEntity.Area.Width, gridEntity.Area.Height), cellDTOs);
	}
}