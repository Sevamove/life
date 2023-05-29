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
		base.Render();
		this.componentHelper.Render(ComponentId.NewGameForm);
	}

	public async override Task<ComponentResult> Execute()
	{
		// await base.Execute();
		return await this.componentHelper.Execute(ComponentId.NewGameForm);
	}
}