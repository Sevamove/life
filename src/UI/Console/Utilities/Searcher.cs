using UI.Console.Converters;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;
using UI.Console.Factories.Button;
using UI.Console.Factories.NavBar;
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

	public static IElement? GetElement(ElementId elementId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetElementId() == elementId)
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

	public static INav? GetNav(ComponentId componentId)
	{
		INav[] navBars = NavBarFactory.GetAllNavBars();

		foreach (var navBar in navBars)
		{
			if (navBar.GetComponentId() == componentId)
			{
				return navBar;
			}
		}

		return null;
	}

	public static INav? GetNav(string componentIdString)
	{
		INav[] navBars = NavBarFactory.GetAllNavBars();
		ComponentId componentId = (ComponentId)EnumConverter.ConvertToComponentId(componentIdString);

		foreach (var navBar in navBars)
		{
			if (navBar.GetComponentId() == componentId)
			{
				return navBar;
			}
		}

		return null;
	}

	public static IAnchor? GetAnchor(string componentIdString)
	{
		IComponent[] anchors = AnchorFactory.GetAllAnchors();
		ComponentId componentId = (ComponentId)EnumConverter.ConvertToComponentId(componentIdString);

		foreach (var anchor in anchors)
		{
			if (anchor.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToAnchor(anchor);
			}
		}

		return null;
	}

	public static IButton? GetButton(string componentIdString)
	{
		IComponent[] buttons = ButtonFactory.GetAllButtons();
		ComponentId componentId = (ComponentId)EnumConverter.ConvertToComponentId(componentIdString);

		foreach (var button in buttons)
		{
			if (button.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToButton(button);
			}
		}

		return null;
	}

	public static IButton? GetButton(ComponentId componentId)
	{
		IComponent[] buttons = ButtonFactory.GetAllButtons();

		foreach (var button in buttons)
		{
			if (button.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToButton(button);
			}
		}

		return null;
	}

	public static IAnchor? GetAnchor(ComponentId componentId)
	{
		IComponent[] anchors = AnchorFactory.GetAllAnchors();

		foreach (var anchor in anchors)
		{
			if (anchor.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToAnchor(anchor);
			}
		}

		return null;
	}

	public static IButton? GetButton(ComponentId componentId, IComponent[] components)
	{
		foreach (var component in components)
		{
			if (component.GetComponentId() == componentId)
			{
				return ComponentConverter.ConvertToButton(component);
			}
		}

		return null;
	}
}