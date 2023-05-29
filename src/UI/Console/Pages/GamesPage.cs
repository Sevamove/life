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
		base.Render();
		this.componentHelper.Render(ComponentId.GamesStackedList);
	}

	public async override Task<ComponentResult> Execute()
	{
		// await this.componentHelper.Execute(ComponentId.GamesStackedList);
		// this.componentHelper.Render(ComponentId.GamesStackedList);
		return await this.componentHelper.Execute(ComponentId.GamesStackedList);
	}
}