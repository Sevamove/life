using Infrastructure.DTO;

namespace Infrastructure.Entities.Builders;

public class GridEntityBuilder
{
	public static GridEntity GetGridEntity(GameDTO gameDTO)
	{
		CellEntity[] cellEntities = new CellEntity[gameDTO.Grid.Cells.Length];

		foreach (var cellDTO in gameDTO.Grid.Cells)
		{
			PositionEntity positionEntity = new PositionEntity
			{
				X = cellDTO.Position.X,
				Y = cellDTO.Position.Y
			};

			cellEntities.Append(new CellEntity
			{
				Id = cellDTO.Id,
				Position = positionEntity,
				State = cellDTO.State
			});
		}

		// TODO: refactor.
		AreaEntity areaEntity = new AreaEntity
		{
			Width = gameDTO.Grid.Area.Width,
			Height = gameDTO.Grid.Area.Height
		};

		return new GridEntity { Area = areaEntity, Cells = cellEntities };
	}
}