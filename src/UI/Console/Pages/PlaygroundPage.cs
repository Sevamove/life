using Application;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;

namespace UI.Console.Pages;

public class PlaygroundPage : BasePage
{
	public PlaygroundPage(Game game) : base(game, ComponentsFactory.GetPlaygroundPageComponents(game))
	{
	}
}