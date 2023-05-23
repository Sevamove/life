using Application;
using UI.Console.Components.Common;
using UI.Console.Components.GoToButtons;

namespace UI.Console.Components.Factories;

public class ButtonFactory
{
	public static BaseButton[] GetAllButtons(Game game)
	{
		BaseButton[] goToButtons = GoToButtonFactory.GetAllGoToButtons();
		BaseButton[] crudButtons = new BaseButton[] {
			new CreateNewGameButton(game),
			new LoadGamesButton(game)
		};

		int length = goToButtons.Length + crudButtons.Length;

		BaseButton[] allButtons = new BaseButton[length];

		foreach (var crudButton in crudButtons)
		{
			allButtons.Append(crudButton);
		}

		foreach (var goToButton in goToButtons)
		{
			allButtons.Append(goToButton);
		}

		System.Console.WriteLine(allButtons.Length);

		return allButtons;
	}
}