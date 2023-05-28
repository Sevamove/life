using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;
using UI.Console.Types;

namespace UI.Console.Components.Anchors;

public class GoToGamesPageAnchor : BaseAnchor
{
	public GoToGamesPageAnchor() : base(
		ComponentId.GoToGamesPageAnchor,
		"Go to the games page",
		$"Type {(int)ComponentId.GoToGamesPageAnchor} to go to the games page.",
		AnchorChildrenFactory.GetGoToGamesPageAnchorChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to games page button clicked!");

		this.componentStorage.Router.Push(Page.Games);

		return await base.Execute();
	}
}