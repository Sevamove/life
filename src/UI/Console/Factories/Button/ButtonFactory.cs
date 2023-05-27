using Application.Interfaces;
using UI.Console.Components.Buttons;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Button;

public static class ButtonFactory
{
	public static IComponent GetPostGameButton(IRestApi restApi)
	{
		return new PostGameButton(restApi);
	}
}