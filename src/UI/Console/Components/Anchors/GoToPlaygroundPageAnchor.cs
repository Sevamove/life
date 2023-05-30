using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;

namespace UI.Console.Components.Anchors;

public class GoToPlaygroundPageAnchor : BaseAnchor
{
	public GoToPlaygroundPageAnchor() : base(
		ComponentId.GoToPlaygroundPageAnchor,
		"Go to playground page",
		$"Type {(int)ComponentId.GoToPlaygroundPageAnchor} to go to the playground page.",
		AnchorChildrenFactory.GetGoToPlaygroundPageAnchorChildren(),
		Page.Playground)
	{
	}
}