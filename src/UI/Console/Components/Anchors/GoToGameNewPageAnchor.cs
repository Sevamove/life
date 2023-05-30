using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;

namespace UI.Console.Components.Anchors;

public class GoToGameNewPageAnchor : BaseAnchor
{
	public GoToGameNewPageAnchor() :
		base(
			ComponentId.GoToGameNewPageAnchor,
			"Go to create new game page",
			$"Type {(int)ComponentId.GoToGameNewPageAnchor} to go to the create new game page.",
			AnchorChildrenFactory.GetGoToGameNewPageAnchorChildren(),
			Page.GameNew)
	{
	}
}