using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;

namespace UI.Console.Components.Anchors;

public class GoToGamesPageAnchor : BaseAnchor
{
	public GoToGamesPageAnchor() : base(
		ComponentId.GoToGamesPageAnchor,
		"Go to the games page",
		$"Type {(int)ComponentId.GoToGamesPageAnchor} to go to the games page.",
		AnchorChildrenFactory.GetGoToGamesPageAnchorChildren(),
		Page.Games)
	{
	}
}