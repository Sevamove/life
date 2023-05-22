using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;

namespace UI.Console.Components.GoToButtons;

public class GoToHomePageButton : BaseButton
{
	public GoToHomePageButton() : base(
		ElementId.GoToHomePageButton,
		"Go to home page",
		$"Type {(int)Page.Home} to go to the home page.")
	{
	}

	public override void OnClick()
	{
		System.Console.WriteLine("Go to home page button clicked!");

		// Event.Invoke(Page.Home);
	}
}