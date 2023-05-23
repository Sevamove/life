using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToGameNewPageButton : BaseButton
{
	public GoToGameNewPageButton() :
		base(
			ElementId.GoToGameNewPageButton,
			"Go to create new game page",
			$"Type {(int)Page.Game_New} to go to the create new game page.")
	{
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Go to game new page button clicked!");

		return new ClickResult
		{
			GameDTOs = null,
			Page = Page.Game_New,
		};
	}
}