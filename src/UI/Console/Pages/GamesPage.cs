using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Types;

namespace UI.Console.Pages;

public class GamesPage : BasePage
{
	public GamesPage() : base(
		ComponentId.GamesPage,
		PageChildrenFactory.GetGamesPageChildren())
	{
	}

	public override void Render()
	{
		this.componentHelper.Render(ComponentId.GamesNavBar);
	}

	public async override Task<ComponentResult> Execute()
	{
		ComponentResult navBarResult = await this.componentHelper.Execute(ComponentId.GamesNavBar);

		return navBarResult;
	}
}