using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Types;

namespace UI.Console.Pages;

public class PlaygroundPage : BasePage
{
	public PlaygroundPage() : base(
		ComponentId.PlaygroundPage,
		PageChildrenFactory.GetPlaygroundPageChildren())
	{
	}

	public override void Render()
	{
		base.Render();
		this.componentHelper.Render(ComponentId.GridSection);
	}

	public async override Task<ComponentResult> Execute()
	{
		return await this.componentHelper.Execute(ComponentId.GridSection);
	}
}