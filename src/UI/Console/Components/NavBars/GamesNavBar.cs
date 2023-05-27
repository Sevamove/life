using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.NavBar;
using UI.Console.Types;

namespace UI.Console.Components.NavBars;

public class GamesNavBar : BaseNav
{
	public GamesNavBar() : base(
		ComponentId.GamesNavBar,
		NavBarChildrenFactory.GetGamesNavBarChildren())
	{
	}

	public override void Render()
	{
		base.Render();
	}

	public async override Task<ComponentResult> Execute()
	{
		return await base.Execute();
	}
}