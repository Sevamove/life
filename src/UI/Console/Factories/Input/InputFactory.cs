using UI.Console.Components.Inputs;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Input;

public static class InputFactory
{
	public static IComponent[] GetAllInputs()
	{
		return new IComponent[] {
			GetGameNameInput(),
			GetGridAreaInput(),
			GetCellPositionInput(),
			GetMoreCellsInput()
		};
	}

	public static IComponent GetGameNameInput()
	{
		return new GameNameInput();
	}

	public static IComponent GetGridAreaInput()
	{
		return new GridAreaInput();
	}

	public static IComponent GetCellPositionInput()
	{
		return new CellPositionInput();
	}

	public static IInput GetMoreCellsInput()
	{
		return new MoreCellsInput();
	}
}