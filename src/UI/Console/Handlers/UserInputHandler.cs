using UI.Console.Enums;

namespace UI.Console.Handlers;

public class UserInputHandler
{
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