using Application.Interfaces;
using UI.Console.Components.NavBars;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Page;

public static class PageChildrenFactory
{
	public static IComponent[] GetHomePageChildren()
	{
		return new IComponent[] {
			new HomeNavBar()
		};
	}

	public static IComponent[] GetGamesPageChildren()
	{
		return new IComponent[] {
			new GamesNavBar()
		};
	}

	public static IComponent[] GetPlaygroundPageChildren()
	{
		return new IComponent[] {
			new PlaygroundNavBar()
			// new GridSection(restApi)
		};
	}

	public static IComponent[] GetGameNewPageChildren()
	{
		return new IComponent[] {
			new GameNewNavBar()
			// new NewGameForm(restApi),
		};
	}
}