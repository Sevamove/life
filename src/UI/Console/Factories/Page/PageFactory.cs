using Application.Interfaces;
using UI.Console.Interfaces;
using UI.Console.Pages;

namespace UI.Console.Factories.Page;

public class PageFactory
{
	public static IPage GetHomePage()
	{
		return new HomePage();
	}

	public static IPage GetGameNewPage(IRestApi restApi)
	{
		return new GameNewPage(restApi);
	}

	public static IPage GetPlaygroundPage(IRestApi restApi)
	{
		return new PlaygroundPage(restApi);
	}

	public static IPage GetGamesPage(IRestApi restApi)
	{
		return new GamesPage(restApi);
	}
}