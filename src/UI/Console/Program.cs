using UI.Console.Application;

public class Program
{
	public static async Task Main()
	{
		App app = new App();

		await app.Launch();
	}
}

// public class Program
// {
// 	public static void Main()
// 	{
// 		Game game = new Game();

// 		Router router = new Router(Page.Home);

// 		bool isGamePaused = false;

// 		HomePage homePage = new HomePage(game);
// 		GamesPage gamesPage = new GamesPage(game);
// 		GameNewPage gameNewPage = new GameNewPage(game);
// 		PlaygroundPage playgroundPage = new PlaygroundPage(game);

// 		// PageEventSubscriber pageEventSubscriber = new PageEventSubscriber();
// 		// GamesEventSubscriber gamesEventSubscriber = new GamesEventSubscriber();
// 		// GameNewEventSubscriber gameNewEventSubscriber = new GameNewEventSubscriber();

// 		GameDTO[]? gameDTOs = null;

// 		// PageEventPublisher pageEventPublisher = new PageEventPublisher();

// 		while (true)
// 		{
// 			switch (router.GetCurrentpage())
// 			{
// 				case Page.Home:
// 					while (true)
// 					{
// 						homePage.Render();
// 						string userInput = UserInputListener.Listen(homePage.ChildComponents);
// 						ElementId buttonId = UserInputHandler.Handle(userInput);
// 						BaseButton button = Searcher.GetButton(buttonId, game);
// 						ButtonResult clickResult = ComponentHandler.HandleButton(button);

// 						gameDTOs = clickResult.GameDTOs;

// 						if (clickResult.Page != null)
// 						{
// 							router.Push((Page)clickResult.Page);
// 							break;
// 						}
// 					}
// 					break;
// 				case Page.Game_New:
// 					while (true)
// 					{
// 						gameNewPage.Render();
// 						string userInput = UserInputListener.Listen(gameNewPage.ChildComponents);
// 						ElementId buttonId = UserInputHandler.Handle(userInput);
// 						BaseButton button = Searcher.GetButton(buttonId, game);
// 						ButtonResult clickResult = ComponentHandler.HandleButton(button);

// 						gameDTOs = clickResult.GameDTOs;

// 						if (clickResult.Page != null)
// 						{
// 							router.Push((Page)clickResult.Page);
// 							break;
// 						}
// 					}
// 					break;
// 				// case Page.Games:
// 				// 	gamesPage.Render();
// 				// 	router.Push(Page.Games);
// 				// 	break;
// 				case Page.Playground:
// 					while (true)
// 					{
// 						playgroundPage.Render();
// 						string userInput = UserInputListener.Listen(playgroundPage.ChildComponents);
// 						ElementId buttonId = UserInputHandler.Handle(userInput);
// 						BaseButton button = Searcher.GetButton(buttonId, game);
// 						ButtonResult clickResult = ComponentHandler.HandleButton(button);

// 						gameDTOs = clickResult.GameDTOs;

// 						if (clickResult.Page != null)
// 						{
// 							router.Push((Page)clickResult.Page);
// 							break;
// 						}
// 					}
// 					break;
// 				default:
// 					break;
// 			}

// 			// TODO: remove break before acceptatietesten.
// 			// break;
// 		}
// 	}
// }

// // public class Program
// // {
// // 	public static void Main()
// // 	{
// // 		Game game = new Game();

// // 		Route route = new Route(Page.Home);

// // 		HomePage homePage = new HomePage(game);
// // 		GridsPage gridsPage = new GridsPage(game);
// // 		GameNewPage gameNewPage = new GameNewPage(game);

// // 		PageEventSubscriber pageEventSubscriber = new PageEventSubscriber();
// // 		GamesEventSubscriber gamesEventSubscriber = new GamesEventSubscriber();
// // 		GameNewEventSubscriber gameNewEventSubscriber = new GameNewEventSubscriber();

// // 		// PageEventPublisher pageEventPublisher = new PageEventPublisher();

// // 		while (true)
// // 		{
// // 			// switch (pageEventSubscriber.Pull())
// // 			switch (route.GetCurrentpage())
// // 			{
// // 				case Page.Home:
// // 					homePage.Render();
// // 					homePage.HandleOnClick();

// // 					// // Array.ForEach(
// // 					// // 	homePage.NavBarComponent.ChildComponents,
// // 					// // 	(value) => value.Event += pageEventSubscriber.UpdateCurrentPage);

// // 					// string? chosenOptionString = String.Empty;
// // 					// int chosenOptionInt = -1;

// // 					// while (true)
// // 					// {
// // 					// 	chosenOptionString = System.Console.ReadLine();

// // 					// 	bool success = int.TryParse(chosenOptionString, out chosenOptionInt);

// // 					// 	if (success)
// // 					// 	{

// // 					// 		// var newCurrentPage = Array.Find(homePage.NavBarComponent.ChildComponents,
// // 					// 		// 	(value) => value.Href() == (Page)chosenOptionInt);

// // 					// 		// // button?.OnClick();
// // 					// 		// route.Push((Page)newCurrentPage);
// // 					// 		break;
// // 					// 	}

// // 					// 	System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// // 					// }

// // 					break;
// // 				// case Page.Games:
// // 				// 	gridsPage.Render();

// // 				// 	Array.ForEach(
// // 				// 		gridsPage.NavBarComponent.ChildComponents,
// // 				// 		(value) => value.Event += gamesEventSubscriber.UpdateFetchedGames);

// // 				// 	string? chosenOptionString1 = String.Empty;
// // 				// 	int chosenOptionInt1 = -1;

// // 				// 	while (true)
// // 				// 	{
// // 				// 		chosenOptionString1 = System.Console.ReadLine();

// // 				// 		bool success = int.TryParse(chosenOptionString1, out chosenOptionInt1);

// // 				// 		if (success)
// // 				// 		{
// // 				// 			// TODO

// // 				// 			// var button = Array.Find(gridsPage.NavBarComponent.ChildComponents,
// // 				// 			// (value) => value.Href() == (Page)chosenOptionInt1);

// // 				// 			// button?.OnClick();
// // 				// 			break;
// // 				// 		}

// // 				// 		System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// // 				// 	}

// // 				// 	break;
// // 				// case Page.Game_New:
// // 				// 	gameNewPage.Render();

// // 				// 	Array.ForEach(
// // 				// 		gameNewPage.NavBarComponent.ChildComponents,
// // 				// 		(value) => value.Event += gameNewEventSubscriber.UpdateNewGame);

// // 				// 	string? chosenOptionString2 = String.Empty;
// // 				// 	int chosenOptionInt2 = -1;

// // 				// 	while (true)
// // 				// 	{
// // 				// 		chosenOptionString2 = System.Console.ReadLine();

// // 				// 		bool success = int.TryParse(chosenOptionString2, out chosenOptionInt2);

// // 				// 		if (success)
// // 				// 		{
// // 				// 			// TODO 

// // 				// 			// var button = Array.Find(gameNewPage.NavBarComponent.ChildComponents,
// // 				// 			// (value) => value.Href() == (Page)chosenOptionInt2);

// // 				// 			// button?.OnClick();
// // 				// 			break;
// // 				// 		}

// // 				// 		System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// // 				// 	}

// // 				// 	break;
// // 				default:
// // 					break;
// // 			}
// // 		}





// // 		// Page currentPage = pageEventSubscriber.Pull();
// // 		// System.Console.WriteLine("Current page is " + currentPage);
// // 	}
// // }
