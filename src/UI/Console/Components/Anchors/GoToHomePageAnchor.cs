using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Anchor;
using UI.Console.Types;

namespace UI.Console.Components.Anchors;

public class GoToHomePageAnchor : BaseAnchor
{
	public GoToHomePageAnchor() : base(
		ComponentId.GoToHomePageAnchor,
		"Go to home page",
		$"Type {(int)ComponentId.GoToHomePageAnchor} to go to the home page.",
		AnchorChildrenFactory.GetGoToHomePageAnchorChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to home page button clicked!");

		this.componentStorage.Router.Push(Page.Home);

		return await this.GetComponentResult();
	}
}