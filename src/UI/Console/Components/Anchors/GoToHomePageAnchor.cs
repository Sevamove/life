using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;

namespace UI.Console.Components.Anchors;

public class GoToHomePageAnchor : BaseAnchor
{
	public GoToHomePageAnchor() : base(
		ComponentId.GoToHomePageAnchor,
		"Go to home page",
		$"Type {(int)ComponentId.GoToHomePageAnchor} to go to the home page.",
		AnchorChildrenFactory.GetGoToHomePageAnchorChildren(),
		Page.Home)
	{
	}
}