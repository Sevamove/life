using UI.Console.Interfaces;
using UI.Console.Pages;

namespace UI.Console.Factories.Page;

public class PageFactory
{
	public static IPage[] GetAllPages()
	{
		return new IPage[] {
			GetHomePage(),
			GetGameNewPage(),
			GetPlaygroundPage(),
			GetGamesPage()
		};
	}

	public static IPage GetHomePage()
	{
		return new HomePage();
	}

	public static IPage GetGameNewPage()
	{
		return new GameNewPage();
	}

	public static IPage GetPlaygroundPage()
	{
		return new PlaygroundPage();
	}

	public static IPage GetGamesPage()
	{
		return new GamesPage();
	}
}