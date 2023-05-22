using Application;
using UI.Console.Components.Common;
using UI.Console.Components.GoToButtons;

namespace UI.Console.Components.Factories;

public class NavBarFactory
{
	public static NavBar GetHomeNavBar(Game game)
	{
		BaseComponent[] childComponents = new BaseComponent[] {
			new GoToGameNewPageButton(),
			new GoToGamesPageButton()
		};

		return new NavBar(game, childComponents);
	}

	public static NavBar GetGamesNavBar(Game game)
	{
		BaseComponent[] childComponents = new BaseComponent[] {
			new LoadGamesButton(game),
		};

		return new NavBar(game, childComponents);
	}

	public static NavBar GetGameNewNavBar(Game game)
	{
		BaseComponent[] childComponents = new BaseComponent[] {
			new CreateNewGameButton(game)
		};

		return new NavBar(game, childComponents);
	}

	public static NavBar GetPlaygroundNavBar(Game game)
	{
		throw new NotImplementedException();
	}
}