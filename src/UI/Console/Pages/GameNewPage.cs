using Application.Interfaces;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Pages;

public class GameNewPage : BasePage
{
	public GameNewPage(IRestApi restApi) : base(
		ComponentId.GameNewPage,
		ComponentsFactory.GetGameNewPageChildComponents(restApi))
	{
	}

	public override void Render()
	{
		this.componentHelper.Render(ComponentId.GameNewNavBar);
	}

	public async override Task<ComponentResult> Execute()
	{
		ComponentResult navBarResult = await this.componentHelper.Execute(ComponentId.GameNewNavBar);

		return navBarResult;
	}
}