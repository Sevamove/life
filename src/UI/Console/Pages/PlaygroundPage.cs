using Application.Interfaces;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Pages;

public class PlaygroundPage : BasePage
{
	public PlaygroundPage(IRestApi restApi) : base(
		ComponentId.PlaygroundPage,
		ComponentsFactory.GetPlaygroundPageChildComponents(restApi))
	{
	}

	public override void Render()
	{
		this.componentHelper.Render(ComponentId.PlaygroundNavBar);
	}

	public async override Task<ComponentResult> Execute()
	{
		ComponentResult navBarResult = await this.componentHelper.Execute(ComponentId.PlaygroundNavBar);

		return navBarResult;
	}
}