using Application;
using UI.Console.Components.Common;

namespace UI.Console.Components.Factories;

public class ComponentsFactory
{
	public static BaseComponent[] GetHomePageComponents(Game game)
	{
		BaseComponent[] components = new BaseComponent[] {
			NavBarFactory.GetHomeNavBar(game)
		};

		return components;
	}

	public static BaseComponent[] GetGamesPageComponents(Game game)
	{
		BaseComponent[] components = new BaseComponent[] {
			NavBarFactory.GetGamesNavBar(game)
		};

		return components;
	}

	public static BaseComponent[] GetGameNewPageComponents(Game game)
	{
		BaseComponent[] components = new BaseComponent[] {
			NavBarFactory.GetGameNewNavBar(game)
		};

		return components;
	}

	public static BaseComponent[] GetPlaygroundPageComponents(Game game)
	{
		BaseComponent[] components = new BaseComponent[] {
			NavBarFactory.GetPlaygroundNavBar(game)
		};

		return components;
	}
}