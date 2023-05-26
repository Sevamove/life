using UI.Console.Converters;
using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Utilities;

public class Searcher
{
	public static IComponent? GetComponent(ComponentId componentId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetComponentId() == componentId)
			{
				return component;
			}
		}

		return null;
	}

	public static IPage? GetPage(ComponentId componentId, IPage[] pages)
	{
		foreach (var page in pages)
		{
			if (page.GetComponentId() == componentId)
			{
				return page;
			}
		}

		return null;
	}

	public static IInput?[] GetInputs(IComponent[] components)
	{
		List<IInput?> inputs = new List<IInput?>();

		foreach (var component in components)
		{
			if (component.GetElementId() == ElementId.Input)
			{
				IInput? input = ComponentConverter.ConvertToInput(component);

				inputs.Add(input);
			}
		}

		return inputs.ToArray();
	}

	public static INav? GetNav(ComponentId componentId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToNav(component);
			}
		}

		return null;
	}

	public static IAnchor? GetAnchor(ComponentId componentId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToAnchor(component);
			}
		}

		return null;
	}

	public static IButton<T>? GetButton<T>(ComponentId componentId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToButton<T>(component);
			}
		}

		return null;
	}
}