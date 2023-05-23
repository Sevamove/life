using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToPlaygroundPageButton : BaseButton
{
	public GoToPlaygroundPageButton() : base(
		ElementId.GoToPlaygroundPageButton,
		"Go to playground page",
		$"Type {(int)Page.Playground} to go to the playground page.")
	{
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Go to playground page button clicked!");

		return new ClickResult
		{
			GameDTOs = null,
			Page = Page.Playground
		};
	}
}