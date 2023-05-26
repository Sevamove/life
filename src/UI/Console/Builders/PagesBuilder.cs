using Application.Interfaces;
using UI.Console.Interfaces;
using UI.Console.Pages;

namespace UI.Console.Builders;

public class PagesBuilder
{
	public static IPage[] GetAllPages(IRestApi restApi)
	{
		return new IPage[] {
			new HomePage(),
			new PlaygroundPage(restApi),
			new GameNewPage(restApi),
			new GamesPage(restApi)
		};
	}
}