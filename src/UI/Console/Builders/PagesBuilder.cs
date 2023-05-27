using UI.Console.Factories.Page;
using UI.Console.Interfaces;

namespace UI.Console.Builders;

public class PagesBuilder
{
	public static IPage[] GetAllPages()
	{
		return new IPage[] {
			PageFactory.GetHomePage(),
			PageFactory.GetPlaygroundPage(),
			PageFactory.GetGameNewPage(),
			PageFactory.GetGamesPage()
		};
	}
}