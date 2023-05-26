using UI.Console.Components.Common;
using UI.Console.Enums;

namespace UI.Console.Listeners;

public class UserInputListener
{
	private readonly BaseComponent[] components;

	public UserInputListener(BaseComponent[] components)
	{
		this.components = components;
	}

	// TODO: create an apart class UserInputValidator.
	public static string? Listen()
	{
		string? userInput = System.Console.ReadLine();

		// if (userInput != null && userInput != "")
		foreach (ComponentId componentId in Enum.GetValues(typeof(ComponentId)))
		{
			int parsedInput = -1;

			bool success = int.TryParse(userInput, out parsedInput);

			if (!success)
			{
				System.Console.WriteLine("Invalid user input provided");
				return ((int)ComponentId.InvalidComponentId).ToString();
			}

			if ((int)componentId == parsedInput)
			{
				return userInput;
			}
		}

		return ((int)ComponentId.HomePage).ToString();
	}

	// // TODO: do we need this method?
	// public static string Listen(BaseComponent[] components)
	// {
	// 	string? userInput = System.Console.ReadLine();

	// 	if (userInput != null && userInput != "")
	// 	{
	// 		return userInput;
	// 	}

	// 	// TODO: handle exception better.
	// 	throw new Exception("Invalid user input provided.");
	// }

}