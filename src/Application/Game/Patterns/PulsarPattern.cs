// // https://conwaylife.com/ref/lexicon/lex_p.htm#pulsar
// using Domain.CellPosition;
// using Domain.CellState;

// namespace Domain.GamePatterns;

// public static class PulsarPattern
// {
// 	private static readonly Cell[] cells = new Cell[] {
// 			new Cell(new Position(2, 4), State.LIVE),
// 			new Cell(new Position(2, 5), State.LIVE),
// 			new Cell(new Position(2, 6), State.LIVE),
// 			new Cell(new Position(2, 10), State.LIVE),
// 			new Cell(new Position(2, 11), State.LIVE),
// 			new Cell(new Position(2, 12), State.LIVE),
// 			new Cell(new Position(4, 2), State.LIVE),
// 			new Cell(new Position(4, 7), State.LIVE),
// 			new Cell(new Position(4, 9), State.LIVE),
// 			new Cell(new Position(4, 14), State.LIVE),
// 			new Cell(new Position(5, 2), State.LIVE),
// 			new Cell(new Position(5, 7), State.LIVE),
// 			new Cell(new Position(5, 9), State.LIVE),
// 			new Cell(new Position(5, 14), State.LIVE),
// 			new Cell(new Position(6, 2), State.LIVE),
// 			new Cell(new Position(6, 7), State.LIVE),
// 			new Cell(new Position(6, 9), State.LIVE),
// 			new Cell(new Position(6, 14), State.LIVE),
// 			new Cell(new Position(7, 4), State.LIVE),
// 			new Cell(new Position(7, 5), State.LIVE),
// 			new Cell(new Position(7, 6), State.LIVE),
// 			new Cell(new Position(7, 10), State.LIVE),
// 			new Cell(new Position(7, 11), State.LIVE),
// 			new Cell(new Position(7, 12), State.LIVE),
// 			new Cell(new Position(9, 4), State.LIVE),
// 			new Cell(new Position(9, 5), State.LIVE),
// 			new Cell(new Position(9, 6), State.LIVE),
// 			new Cell(new Position(9, 10), State.LIVE),
// 			new Cell(new Position(9, 11), State.LIVE),
// 			new Cell(new Position(9, 12), State.LIVE),
// 			new Cell(new Position(10, 2), State.LIVE),
// 			new Cell(new Position(10, 7), State.LIVE),
// 			new Cell(new Position(10, 9), State.LIVE),
// 			new Cell(new Position(10, 14), State.LIVE),
// 			new Cell(new Position(11, 2), State.LIVE),
// 			new Cell(new Position(11, 7), State.LIVE),
// 			new Cell(new Position(11, 9), State.LIVE),
// 			new Cell(new Position(11, 14), State.LIVE),
// 			new Cell(new Position(12, 2), State.LIVE),
// 			new Cell(new Position(12, 7), State.LIVE),
// 			new Cell(new Position(12, 9), State.LIVE),
// 			new Cell(new Position(12, 14), State.LIVE),
// 			new Cell(new Position(14, 4), State.LIVE),
// 			new Cell(new Position(14, 5), State.LIVE),
// 			new Cell(new Position(14, 6), State.LIVE),
// 			new Cell(new Position(14, 10), State.LIVE),
// 			new Cell(new Position(14, 11), State.LIVE),
// 			new Cell(new Position(14, 12), State.LIVE), };

// 	public static Cell[] GetCells()
// 	{
// 		return cells;
// 	}
// }