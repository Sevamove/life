using UI.Console.Interfaces;

namespace UI.Console.Factories.Button;

public static class ButtonChildrenFactory
{
	public static IComponent[] GetPostGameButtonChildren()
	{
		return new IComponent[] { };
	}

	public static IComponent[] GetQuitGameButtonChildren()
	{
		return new IComponent[] { };
	}
}