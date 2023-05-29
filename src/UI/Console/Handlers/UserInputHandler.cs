using UI.Console.Converters;
using UI.Console.Enums;
using UI.Console.Listeners;
using UI.Console.Validators;

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

	public static ComponentId HandleGameNameInputValue()
	{
		string? userInput = UserInputListener.Listen();

		if (UserInputValidator.IsValidNavBarInputValue(userInput))
		{
			return (ComponentId)EnumConverter.ConvertToComponentId(userInput);
		}

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

	// Create game form
	//
	// Validate whether clicked on go to button.
	// If not clicked then take and validate input.
	// If not clicked then take and validate input.
	// If not clicked then take and validate input.
	// Ask to post game and send to playground. 

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