using UI.Console.Components.NavBars;
using UI.Console.Interfaces;

namespace UI.Console.Factories.NavBar;

public static class NavBarFactory
{
	public static INav[] GetAllNavBars()
	{
		return new INav[] {
			GetHomeNavBar(),
			GetGameNewNavBar(),
			GetGamesNavBar(),
			GetPlaygroundNavBar()
		};
	}

	public static INav GetHomeNavBar()
	{
		return new HomeNavBar();
	}

	public static INav GetGameNewNavBar()
	{
		return new GameNewNavBar();
	}

	public static INav GetGamesNavBar()
	{
		return new GamesNavBar();
	}

	public static INav GetPlaygroundNavBar()
	{
		return new PlaygroundNavBar();
	}
}