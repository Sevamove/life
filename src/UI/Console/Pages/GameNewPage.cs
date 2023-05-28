using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Types;

namespace UI.Console.Pages;

public class GameNewPage : BasePage
{
	public GameNewPage() : base(
		ComponentId.GameNewPage,
		PageChildrenFactory.GetGameNewPageChildren())
	{
	}

	public override void Render()
	{
		this.componentHelper.Render(ComponentId.GameNewNavBar);
		this.componentHelper.Render(ComponentId.NewGameForm);
	}

	public async override Task<ComponentResult> Execute()
	{
		// Storage navBarResult = await this.componentHelper.Execute(ComponentId.GameNewNavBar);
		return await this.componentHelper.Execute(ComponentId.NewGameForm);
	}
}