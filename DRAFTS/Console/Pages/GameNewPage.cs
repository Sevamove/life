using Application;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;

namespace UI.Console.Pages;

public class GameNewPage : BasePage
{
	public GameNewPage(Game game) : base(game, ComponentsFactory.GetGameNewPageComponents(game))
	{
	}
}