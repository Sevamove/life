using UI.Console.Components.Common;

namespace UI.Console.Listeners;

public class UserInputListener
{
	private readonly BaseComponent[] components;

	public UserInputListener(BaseComponent[] components)
	{
		this.components = components;
	}

	public static string Listen(BaseComponent[] components)
	{
		string? userInput = System.Console.ReadLine();

		if (userInput != null && userInput != "")
		{
			return userInput;
		}

		// TODO: handle exception better.
		throw new Exception("Invalid user input provided.");
	}
}