using UI.Console.Components.Common;

namespace UI.Console.Components.GoToButtons;

public class GoToButtonFactory
{
	public static BaseButton[] GetAllGoToButtons()
	{
		return new BaseButton[] {
			new GoToGameNewPageButton(),
			new GoToGamesPageButton(),
			new GoToHomePageButton(),
			new GoToPlaygroundPageButton()
		};
	}
}