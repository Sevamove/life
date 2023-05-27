using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;
using UI.Console.Types;

namespace UI.Console.Components.Anchors;

public class GoToPlaygroundPageAnchor : BaseAnchor
{
	public GoToPlaygroundPageAnchor() : base(
		ComponentId.GoToPlaygroundPageAnchor,
		"Go to playground page",
		$"Type {(int)ComponentId.GoToPlaygroundPageAnchor} to go to the playground page.",
		AnchorChildrenFactory.GetGoToPlaygroundPageAnchorChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to playground page button clicked!");

		return new ComponentResult
		{
			Page = Page.Playground
		};
	}
}