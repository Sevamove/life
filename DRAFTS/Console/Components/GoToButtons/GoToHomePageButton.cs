using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToHomePageButton : BaseButton
{
	public GoToHomePageButton() : base(
		ElementId.GoToHomePageButton,
		"Go to home page",
		$"Type {(int)Page.Home} to go to the home page.")
	{
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Go to home page button clicked!");

		return new ClickResult
		{
			GameDTOs = null,
			Page = Page.Home
		};

		// Event.Invoke(Page.Home);
	}
}