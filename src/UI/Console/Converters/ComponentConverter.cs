using UI.Console.Interfaces;

namespace UI.Console.Converters;

public class ComponentConverter
{
	public static IInput? ConvertToInput(IComponent component)
	{
		return component as IInput;
	}

	public static IAnchor? ConvertToAnchor(IComponent component)
	{
		return component as IAnchor;
	}

	public static INav? ConvertToNav(IComponent component)
	{
		return component as INav;
	}

	public static IButton<T>? ConvertToButton<T>(IComponent component)
	{
		return component as IButton<T>;
	}
}