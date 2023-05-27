using UI.Console.Components.Inputs;
using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Input;

public static class InputFactory
{
	public static IComponent GetGameNameInput()
	{
		return new InputWithLabel(ComponentId.GameNameInput, "Game name", "What is the name of your new game");
	}

	public static IComponent GetCellPositionInput()
	{
		return new InputWithLabel(ComponentId.CellPositionInput, "Cell position (nr. 1)", "Provide a cell position in this form ROW-COLUMN (e.g. 10-12)");
	}

	public static IComponent GetGridAreaInput()
	{
		return new InputWithLabel(ComponentId.GridAreaInput, "Grid area", "Provide the grid area in the next form WIDTH-HEIGHT (e.g. 20-20)");
	}
}