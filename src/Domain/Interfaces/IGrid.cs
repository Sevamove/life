using Domain.ValueObjects.Cell;
using Domain.ValueObjects.Grid;

namespace Domain.Interfaces;

public interface IGrid
{
	// Write methods.

	public void Initialize();
	public void Renew();
	public void Update(Cell[] cells);
	public void Update(Cell[,] cells);

	// Read methods.

	public Area GetArea();
	public Cell GetCell(Position position);
	public Cell[,] GetCells();
}