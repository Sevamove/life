using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Handlers;
using UI.Console.Interfaces;

namespace UI.Console.Listeners;

public class ComponentListener
{
	public static ComponentId Listen(IComponent[] components)
	{
		string? userInput = UserInputListener.Listen();
		ComponentId componentId = UserInputHandler.Handle(userInput);

		return componentId;
	}
}