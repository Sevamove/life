using Application;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;

namespace UI.Console.Pages;

public class HomePage : BasePage
{
	public HomePage(Game game) : base(game, ComponentsFactory.GetHomePageComponents(game))
	{
	}
}

// using Application;
// using Infrastructure.Enums;
// using UI.Console.Components.Common;
// using UI.Console.Components;
// using UI.Console.Components.Common;
// using UI.Console.Components.Factories;
// using UI.Console.Enums;

// // TODO: create IPage interface and inherit this page from it.
// public class HomePage : BasePage
// {
// 	// private readonly Game game;
// 	// private readonly PageEventSubscriber pageEventSubscriber;
// 	// public NavBar<Page> NavBarComponent;

// 	public HomePage(Game game) : base(game, ComponentsFactory.GetHomePageComponents(game))
// 	{
// 		// this.game = game;
// 		// this.pageEventSubscriber = new PageEventSubscriber();
// 		// this.NavBarComponent = NavBarFactory.GetHomeNavBar(this.game);
// 	}

// 	// public void HandleOnClick()
// 	// {
// 	// 	while (true)
// 	// 	{
// 	// 		int userInputInt = -1;
// 	// 		string? userInputString = System.Console.ReadLine();

// 	// 		if (userInputString != null && userInputString != "")
// 	// 		{
// 	// 			bool success = int.TryParse(userInputString, out userInputInt);

// 	// 			if (success)
// 	// 			{
// 	// 				Element<Page>? component = Array.Find(this.NavBarComponent.ChildComponents,
// 	// 					(component) => component.Id == (ElementId)userInputInt);

// 	// 				if (component != null)
// 	// 				{
// 	// 					component.OnClick();
// 	// 					// return component.Href();
// 	// 					break;
// 	// 				}

// 	// 				System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 	// 			}
// 	// 			System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 	// 		}
// 	// 		System.Console.WriteLine("Error occurred. Provided invalid option. Try again.");
// 	// 	}
// 	// }

// 	// public void HandleEvent()
// 	// {
// 	// 	Array.ForEach(
// 	// 		this.NavBarComponent.ChildComponents,
// 	// 		(component) => component.Event += this.pageEventSubscriber.UpdateCurrentPage);
// 	// }

// 	public override void Render()
// 	{
// 		foreach (var childComponent in this.ChildComponents)
// 		{
// 			childComponent.Render();
// 		}
// 	}
// }