// using UI.Console.Components.Common;
// using UI.Console.Components.GoToButtons;
// using UI.Console.Components.NavBars;
// using UI.Console.Interfaces;

// namespace UI.Console.Components.Factories;

// public class NavBarFactory
// {
// 	public static IComponent GetHomeNavBar()
// 	{
// 		IComponent[] childComponents = new IComponent[] {
// 			new GoToGameNewPageAnchor(),
// 			new GoToGamesPageAnchor()
// 		};

// 		return new HomeNavBar();
// 	}

// 	// public static NavBar GetGamesNavBar(Game game)
// 	// {
// 	// 	BaseComponent[] childComponents = new BaseComponent[] {
// 	// 		new GetGamesButton(game),
// 	// 	};

// 	// 	return new NavBar(game, childComponents);
// 	// }

// 	// public static NavBar GetGameNewNavBar(Game game)
// 	// {
// 	// 	BaseComponent[] childComponents = new BaseComponent[] {
// 	// 		new PostGameButton(game)
// 	// 	};

// 	// 	return new NavBar(game, childComponents);
// 	// }

// 	// public static NavBar GetPlaygroundNavBar(Game game)
// 	// {
// 	// 	// TODO: populate the list with components.
// 	// 	BaseComponent[] childComponents = new BaseComponent[] { };

// 	// 	return new NavBar(game, childComponents);
// 	// }
// }