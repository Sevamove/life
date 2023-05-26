using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToGameNewPageAnchor : BaseAnchor
{
	public GoToGameNewPageAnchor() :
		base(
			ComponentId.GoToGameNewPageAnchor,
			"Go to create new game page",
			$"Type {(int)ComponentId.GoToGameNewPageAnchor} to go to the create new game page.",
			ComponentsFactory.GetGoToGameNewPageAnchorChildComponents())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to game new page button clicked!");

		return new ComponentResult
		{
			Page = Page.Game_New
		};
	}
}