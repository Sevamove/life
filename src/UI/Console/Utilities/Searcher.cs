using Application;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Components.GoToButtons;

namespace UI.Console.Utilities;

public class Searcher
{
	public static BaseButton GetButton(ElementId buttonId, Game game)
	{
		BaseButton[] buttons = ButtonFactory.GetAllButtons(game);

		// TODO: solve bug.
		// foreach (var button in buttons)
		// {
		// 	System.Console.WriteLine(button.Id);
		// 	System.Console.WriteLine(buttonId);
		// 	// if (button.Id == buttonId)
		// 	// {
		// 	// 	return button;
		// 	// }
		// }

		// TODO: remove when the bug is solved.
		return new GoToGameNewPageButton();

		// TODO: handle the exception better.
		throw new Exception("Button not found based on the button ID.");
	}
}