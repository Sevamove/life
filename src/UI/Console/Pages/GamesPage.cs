using Application;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;

namespace UI.Console.Pages;

public class GamesPage : BasePage
{
	public GamesPage(Game game) : base(game, ComponentsFactory.GetGamesPageComponents(game))
	{
	}
}