using Application;
using UI.Console.Components.Common;

namespace UI.Console.Components.GoToButtons;

public class CRUDButtonsFactory
{
	public static BaseButton[] GetAllCRUDButtons(Game game)
	{
		return new BaseButton[] {
			new CreateNewGameButton(game),
			new LoadGamesButton(game)
		};
	}
}