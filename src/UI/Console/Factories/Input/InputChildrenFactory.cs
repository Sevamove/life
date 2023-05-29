using UI.Console.Interfaces;

namespace UI.Console.Factories.Input;

public static class InputChildrenFactory
{
	public static IComponent[] GetGameNameInputChildren()
	{
		return new IComponent[] { };
	}

	public static IComponent[] GetCellPositionInputChildren()
	{
		return new IComponent[] { };
	}

	public static IComponent[] GetGridAreaInputChildren()
	{
		return new IComponent[] { };
	}
}