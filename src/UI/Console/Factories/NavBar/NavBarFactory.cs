using UI.Console.Components.NavBars;
using UI.Console.Interfaces;

namespace UI.Console.Factories.NavBar;

public static class NavBarFactory
{
	public static IComponent GetHomeNavBar()
	{
		return new HomeNavBar();
	}

	public static IComponent GetGameNewNavBar()
	{
		return new GameNewNavBar();
	}

	public static IComponent GetGamesNavBar()
	{
		return new GamesNavBar();
	}

	public static IComponent GetPlaygroundNavBar()
	{
		return new PlaygroundNavBar();
	}
}