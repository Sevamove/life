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
			// TODO: handle an invalid user input.
			throw new Exception("Can not handle an invalid user input.");
		}

		ComponentId componentId = (ComponentId)userInputInt;

		return componentId;
	}
}