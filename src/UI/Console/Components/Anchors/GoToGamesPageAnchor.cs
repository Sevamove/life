using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.GoToButtons;

public class GoToGamesPageAnchor : BaseAnchor
{
	public GoToGamesPageAnchor() : base(
		ComponentId.GoToGamesPageAnchor,
		"Go to the games page",
		$"Type {(int)ComponentId.GoToGamesPageAnchor} to go to the games page.",
		ComponentsFactory.GetGoToGamesPageAnchorChildComponents())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Go to games page button clicked!");

		return new ComponentResult
		{
			Page = Page.Games
		};
	}
}