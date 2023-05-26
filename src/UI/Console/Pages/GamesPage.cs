using Application.Interfaces;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Pages;

public class GamesPage : BasePage
{
	public GamesPage(IRestApi restApi) : base(
		ComponentId.GamesPage,
		ComponentsFactory.GetGamesPageChildComponents(restApi))
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