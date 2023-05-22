using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;

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

	public override void OnClick()
	{
		System.Console.WriteLine("Go to game new page button clicked!");

		// Event.Invoke(Page.Game_New);
		// return Page.Playground;
	}
}