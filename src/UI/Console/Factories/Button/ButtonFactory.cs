using UI.Console.Components.Buttons;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Button;

public static class ButtonFactory
{
	public static IComponent[] GetAllButtons()
	{
		return new IComponent[] {
			GetQuitGameButton()
		};
	}

	public static IComponent GetQuitGameButton()
	{
		return new QuitGameButton();
	}
}