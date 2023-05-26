using Application.Interfaces;
using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Pages;

namespace UI.Console.Factories;

public class PageFactory
{
	public static IPage GetHomePage(IPage[] pages)
	{
		foreach (var page in pages)
		{
			if (page.GetComponentId() == ComponentId.HomePage)
			{
				return new HomePage();
			}
		}

		throw new Exception("Page not found error.");
	}

	public static IPage GetGameNewPage(IPage[] pages, IRestApi restApi)
	{
		foreach (var page in pages)
		{
			if (page.GetComponentId() == ComponentId.GameNewPage)
			{
				return new GameNewPage(restApi);
			}
		}

		throw new Exception("Page not found error.");
	}

	public static IPage GetPlaygroundPage(IPage[] pages, IRestApi restApi)
	{
		foreach (var page in pages)
		{
			if (page.GetComponentId() == ComponentId.GameNewPage)
			{
				return new PlaygroundPage(restApi);
			}
		}

		throw new Exception("Page not found error.");
	}
}