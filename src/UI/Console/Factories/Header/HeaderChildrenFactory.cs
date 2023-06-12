using UI.Console.Components.Images;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Header;

public static class HeaderChildrenFactory
{
	public static IComponent[] GetMainHeaderChildren()
	{
		return new IComponent[] { new GameOfLifeLogoImage() };
	}
}