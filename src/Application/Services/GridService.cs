using Application.Interfaces;
using Domain.Aggregates;
using Domain.DTO;
using Domain.Entities;
using Domain.ValueObjects.Cell;
using Domain.ValueObjects.Grid;

namespace Application.Services;

public class GridService : IGridService
{
	public GridService()
	{
	}

	// TODO: technical debt. Refactor!
	public GameDTO GetGrid(GameDTO game)
	{
		Grid grid = new Grid(new Area(game.Grid.Area.Width, game.Grid.Area.Height));
		Cell[,] cells = new Cell[game.Grid.Area.Width, game.Grid.Area.Height];

		for (int x = 0; x < game.Grid.Cells.GetLength(0); x++)
		{
			for (int y = 0; y < game.Grid.Cells.GetLength(1); y++)
			{
				CellDTO cellDTO = game.Grid.Cells[x, y];

				Position position = new Position(cellDTO.Position.X, cellDTO.Position.Y);
				State state = (State)cellDTO.State;

				Cell cell = new Cell(position, state);

				cells[x, y] = cell;
			}
		}

		grid.Update(cells);
		grid.Renew();

		Cell[,] updatedGrid = grid.GetCells();

		CellDTO[,] cellDTOs = new CellDTO[game.Grid.Area.Width, game.Grid.Area.Height];

		for (int x = 0; x < updatedGrid.GetLength(0); x++)
		{
			for (int y = 0; y < updatedGrid.GetLength(1); y++)
			{
				Cell cell = updatedGrid[x, y];

				PositionDTO position = new PositionDTO(cell.GetPosition().X(), cell.GetPosition().Y());
				int state = (int)cell.GetState();

				CellDTO cellDTO = new CellDTO("", position, state);

				cellDTOs[x, y] = cellDTO;
			}
		}

		return new GameDTO(
			game.Id,
			game.Name,
			new GridDTO(
				game.Grid.Area,
				cellDTOs
			)
		);
	}
}