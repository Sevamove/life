using Domain.ValueObjects.Cell;
using Domain.ValueObjects.Cell.SurroundingPositions;
using Domain.ValueObjects.Grid;

namespace Domain.Aggregates;

interface IGrid
{
	// Write methods.

	public void Initialize();
	public void Renew();
	public void Update(Cell[] cells);

	// Read methods.

	public Cell GetCell(Position position);
	public Cell[,] GetCells();
}

public class Grid : IGrid
{
	private readonly Border border;
	private readonly Area area;
	private Cell[,] cells;

	public Grid(Area area)
	{
		this.area = area;
		this.border = new Border(area);
		this.cells = new Cell[area.Width, area.Height];
	}

	public void Initialize()
	{
		for (int x = 0; x < this.cells.GetLength(0); x++)
		{
			for (int y = 0; y < this.cells.GetLength(1); y++)
			{
				this.cells[x, y] = new Cell(new Position(x, y), State.DEAD);
			}
		}
	}

	public void Renew()
	{
		Cell[,] newCells = new Cell[this.area.Width, this.area.Height];

		for (int x = 0; x < this.area.Width; x++)
		{
			for (int y = 0; y < this.area.Height; y++)
			{
				newCells[x, y] = this.updateCell(new Position(x, y));
			}
		}

		this.cells = newCells;
	}

	public void Update(Cell[] cells)
	{
		for (int i = 0; i < cells.Length; i++)
		{
			Cell cell = cells[i];

			int x = cell.GetPosition().X();
			int y = cell.GetPosition().Y();

			this.cells[x, y] = cell;
		}
	}

	public Cell GetCell(Position position)
	{
		return this.cells[position.X(), position.Y()];
	}

	public Cell[,] GetCells()
	{
		return this.cells;
	}

	private Cell updateCell(Position position)
	{
		int amount = this.getNeighborsAmount(position);

		// Create copy of the object because we do not to reference to it. 
		Cell cell = (Cell)this.GetCell(position).Clone();
		cell.SetState(amount);

		return cell;
	}

	private int getNeighborsAmount(Position position)
	{
		int result = 0;
		List<ISurroundingPosition> positions = SurroundingPositionsFactory.GetApplicableSurroundingPositions(this.border, position);

		for (int i = 0; i < positions.Count; i++)
		{
			result += (int)this.GetCell(positions[i].Get(position)).GetState();
		}

		return result;
	}
}
