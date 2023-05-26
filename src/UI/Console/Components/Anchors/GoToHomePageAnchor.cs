using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToHomePageAnchor : BaseAnchor
{
	public GoToHomePageAnchor() : base(
		ComponentId.GoToHomePageAnchor,
		"Go to home page",
		$"Type {(int)ComponentId.GoToHomePageAnchor} to go to the home page.",
		ComponentsFactory.GetGoToHomePageAnchorChildComponents())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to home page button clicked!");

		return new ComponentResult
		{
			Page = Page.Home
		};
	}
}