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
		return "1";
	}
}