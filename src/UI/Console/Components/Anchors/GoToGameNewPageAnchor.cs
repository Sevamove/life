using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;
using UI.Console.Types;

namespace UI.Console.Components.Anchors;

public class GoToGameNewPageAnchor : BaseAnchor
{
	public GoToGameNewPageAnchor() :
		base(
			ComponentId.GoToGameNewPageAnchor,
			"Go to create new game page",
			$"Type {(int)ComponentId.GoToGameNewPageAnchor} to go to the create new game page.",
			AnchorChildrenFactory.GetGoToGameNewPageAnchorChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to game new page button clicked!");

		this.componentStorage.Router.Push(Page.Game_New);

		return await this.GetComponentResult();
	}
}