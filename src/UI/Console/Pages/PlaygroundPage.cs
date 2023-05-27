using Application.Interfaces;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Types;

namespace UI.Console.Pages;

public class PlaygroundPage : BasePage
{
	public PlaygroundPage(IRestApi restApi) : base(
		ComponentId.PlaygroundPage,
		PageChildrenFactory.GetPlaygroundPageChildren(restApi))
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