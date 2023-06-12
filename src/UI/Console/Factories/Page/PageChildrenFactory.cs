using UI.Console.Components.Forms;
using UI.Console.Components.Headers;
using UI.Console.Components.NavBars;
using UI.Console.Components.Sections;
using UI.Console.Components.StackedLists;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Page;

public static class PageChildrenFactory
{
	public static IComponent[] GetHomePageChildren()
	{
		return new IComponent[] {
			new MainHeader(),
			new HomeNavBar()
		};
	}

	public static IComponent[] GetGamesPageChildren()
	{
		return new IComponent[] {
			new MainHeader(),
			new GamesNavBar(),
			new GamesStackedList()
		};
	}

	public static IComponent[] GetPlaygroundPageChildren()
	{
		return new IComponent[] {
			new MainHeader(),
			new PlaygroundNavBar(),
			new GridSection()
		};
	}

	public static IComponent[] GetGameNewPageChildren()
	{
		return new IComponent[] {
			new MainHeader(),
			new GameNewNavBar(),
			new NewGameForm(),
		};
	}
}