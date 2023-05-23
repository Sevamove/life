using Application;
using Infrastructure.DTO;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Events;
using UI.Console.Handlers;
using UI.Console.Listeners;
using UI.Console.Pages;
using UI.Console.Types;
using UI.Console.Utilities;

public class Program
{
	public static void Main()
	{
		Game game = new Game();

		Router router = new Router(Page.Home);

		HomePage homePage = new HomePage(game);
		GamesPage gamesPage = new GamesPage(game);
		GameNewPage gameNewPage = new GameNewPage(game);
		PlaygroundPage playgroundPage = new PlaygroundPage(game);

		// PageEventSubscriber pageEventSubscriber = new PageEventSubscriber();
		// GamesEventSubscriber gamesEventSubscriber = new GamesEventSubscriber();
		// GameNewEventSubscriber gameNewEventSubscriber = new GameNewEventSubscriber();

		GameDTO[]? gameDTOs = null;

		// PageEventPublisher pageEventPublisher = new PageEventPublisher();

		while (true)
		{
			switch (router.GetCurrentpage())
			{
				case Page.Home:
					while (true)
					{
						homePage.Render();
						string userInput = UserInputListener.Listen(homePage.ChildComponents);
						ElementId buttonId = ElementId.GoToGameNewPageButton;
						BaseButton button = Searcher.GetButton(buttonId, game);
						ClickResult clickResult = UserInputHandler.HandleButton(button);

						gameDTOs = clickResult.GameDTOs;

						if (clickResult.Page != null)
						{
							router.SetCurrentPage((Page)clickResult.Page);
							break;
						}
					}
					break;
				// case Page.Game_New:
				// 	gameNewPage.Render();
				// 	router.SetCurrentPage(Page.Games);
				// 	break;
				// case Page.Games:
				// 	gamesPage.Render();
				// 	router.SetCurrentPage(Page.Games);
				// 	break;
				// case Page.Playground:
				// 	playgroundPage.Render();
				// 	router.SetCurrentPage(Page.Playground);
				// 	break;
				default:
					break;
			}

			// TODO: remove break before acceptatietesten.
			break;
		}
	}
}

// public class Program
// {
// 	public static void Main()
// 	{
// 		Game game = new Game();

// 		Route route = new Route(Page.Home);

// 		HomePage homePage = new HomePage(game);
// 		GridsPage gridsPage = new GridsPage(game);
// 		GameNewPage gameNewPage = new GameNewPage(game);

// 		PageEventSubscriber pageEventSubscriber = new PageEventSubscriber();
// 		GamesEventSubscriber gamesEventSubscriber = new GamesEventSubscriber();
// 		GameNewEventSubscriber gameNewEventSubscriber = new GameNewEventSubscriber();

// 		// PageEventPublisher pageEventPublisher = new PageEventPublisher();

// 		while (true)
// 		{
// 			// switch (pageEventSubscriber.GetCurrentPage())
// 			switch (route.GetCurrentpage())
// 			{
// 				case Page.Home:
// 					homePage.Render();
// 					homePage.HandleOnClick();

// 					// // Array.ForEach(
// 					// // 	homePage.NavBarComponent.ChildComponents,
// 					// // 	(value) => value.Event += pageEventSubscriber.UpdateCurrentPage);

// 					// string? chosenOptionString = String.Empty;
// 					// int chosenOptionInt = -1;

// 					// while (true)
// 					// {
// 					// 	chosenOptionString = System.Console.ReadLine();

// 					// 	bool success = int.TryParse(chosenOptionString, out chosenOptionInt);

// 					// 	if (success)
// 					// 	{

// 					// 		// var newCurrentPage = Array.Find(homePage.NavBarComponent.ChildComponents,
// 					// 		// 	(value) => value.Href() == (Page)chosenOptionInt);

// 					// 		// // button?.OnClick();
// 					// 		// route.SetCurrentPage((Page)newCurrentPage);
// 					// 		break;
// 					// 	}

// 					// 	System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 					// }

// 					break;
// 				// case Page.Games:
// 				// 	gridsPage.Render();

// 				// 	Array.ForEach(
// 				// 		gridsPage.NavBarComponent.ChildComponents,
// 				// 		(value) => value.Event += gamesEventSubscriber.UpdateFetchedGames);

// 				// 	string? chosenOptionString1 = String.Empty;
// 				// 	int chosenOptionInt1 = -1;

// 				// 	while (true)
// 				// 	{
// 				// 		chosenOptionString1 = System.Console.ReadLine();

// 				// 		bool success = int.TryParse(chosenOptionString1, out chosenOptionInt1);

// 				// 		if (success)
// 				// 		{
// 				// 			// TODO

// 				// 			// var button = Array.Find(gridsPage.NavBarComponent.ChildComponents,
// 				// 			// (value) => value.Href() == (Page)chosenOptionInt1);

// 				// 			// button?.OnClick();
// 				// 			break;
// 				// 		}

// 				// 		System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 				// 	}

// 				// 	break;
// 				// case Page.Game_New:
// 				// 	gameNewPage.Render();

// 				// 	Array.ForEach(
// 				// 		gameNewPage.NavBarComponent.ChildComponents,
// 				// 		(value) => value.Event += gameNewEventSubscriber.UpdateNewGame);

// 				// 	string? chosenOptionString2 = String.Empty;
// 				// 	int chosenOptionInt2 = -1;

// 				// 	while (true)
// 				// 	{
// 				// 		chosenOptionString2 = System.Console.ReadLine();

// 				// 		bool success = int.TryParse(chosenOptionString2, out chosenOptionInt2);

// 				// 		if (success)
// 				// 		{
// 				// 			// TODO 

// 				// 			// var button = Array.Find(gameNewPage.NavBarComponent.ChildComponents,
// 				// 			// (value) => value.Href() == (Page)chosenOptionInt2);

// 				// 			// button?.OnClick();
// 				// 			break;
// 				// 		}

// 				// 		System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 				// 	}

// 				// 	break;
// 				default:
// 					break;
// 			}
// 		}





// 		// Page currentPage = pageEventSubscriber.GetCurrentPage();
// 		// System.Console.WriteLine("Current page is " + currentPage);
// 	}
// }
