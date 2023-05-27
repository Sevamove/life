using Application.Interfaces;
using UI.Console.Factories.Page;
using UI.Console.Interfaces;

namespace UI.Console.Builders;

public class PagesBuilder
{
	public static IPage[] GetAllPages(IRestApi restApi)
	{
		return new IPage[] {
			PageFactory.GetHomePage(),
			PageFactory.GetPlaygroundPage(restApi),
			PageFactory.GetGameNewPage(restApi),
			PageFactory.GetGamesPage(restApi)
		};
	}
}