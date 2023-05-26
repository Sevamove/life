// using Application;
// using UI.Console.Components.Common;
// using UI.Console.Components.GoToButtons;

// namespace UI.Console.Components.Factories;

// public class ButtonFactory
// {
// 	public static BaseButton[] GetAllButtons(Game game)
// 	{
// 		BaseButton[] goToButtons = GoToButtonFactory.GetAllGoToButtons();
// 		BaseButton[] crudButtons = CRUDButtonsFactory.GetAllCRUDButtons(game);

// 		List<BaseButton> allButtons = new List<BaseButton>();

// 		foreach (var crudButton in crudButtons)
// 		{
// 			allButtons.Add(crudButton);
// 		}

// 		foreach (var goToButton in goToButtons)
// 		{
// 			allButtons.Add(goToButton);
// 		}

// 		return allButtons.ToArray();
// 	}
// }