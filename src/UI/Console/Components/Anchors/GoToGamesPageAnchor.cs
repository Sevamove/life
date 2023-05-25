using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToGamesPageButton : BaseButton
{
	public GoToGamesPageButton() : base(
		ElementId.GoToGamesPageButton,
		"Go to the games page",
		$"Type {(int)Page.Games} to go to the games page.")
	{
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Go to game page button clicked!");

		return new ClickResult
		{
			GameDTOs = null,
			Page = Page.Games
		};
	}
}