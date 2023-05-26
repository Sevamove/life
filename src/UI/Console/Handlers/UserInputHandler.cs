using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Handlers;

public class UserInputHandler
{
	// private readonly string userInput;
	// private readonly BaseComponent[] components;

	// public UserInputHandler(BaseComponent[] components, string userInput)
	// {
	// 	this.userInput = userInput;
	// 	this.components = components;
	// }

	// public static ButtonResult HandleButton(BaseButton button)
	// {
	// 	return button.OnClick();
	// }

	public static ComponentId Handle(string userInput)
	{
		int userInputInt = -1;

		bool success = int.TryParse(userInput, out userInputInt);

		if (!success)
		{
			// System.Console.WriteLine("Can not handle an invalid user input.");
			// TODO: handle an invalid user input.
			throw new Exception("Can not handle an invalid user input.");
		}

		ComponentId componentId = (ComponentId)userInputInt;

		return componentId;
	}

	// public static void HandleNewGame(string userInput)
	// {
	// 	// 0-2 2-4 1-2
	// 	string[] splittedString = userInput.Split(" ");
	// 	System.Console.WriteLine(splittedString);
	// }

	// private BaseComponent getComponent()
	// {
	// 	int userInputInt = -1;

	// 	bool success = int.TryParse(this.userInput, out userInputInt);

	// 	if (!success)
	// 	{
	// 		// System.Console.WriteLine("Can not handle an invalid user input.");
	// 		// TODO: handle an invalid user input.
	// 		throw new Exception("Can not handle an invalid user input.");
	// 	}

	// 	ElementId componentId = (ElementId)userInputInt;

	// 	var component = Array.Find(
	// 		this.components,
	// 		(component) => component.Id == componentId);

	// 	if (component == null)
	// 	{
	// 		// System.Console.WriteLine("Provided unsupported component.");
	// 		// TODO: handle unsupported components.
	// 		throw new Exception("Provided unsupported component.");
	// 	}

	// 	return component;
	// }
}