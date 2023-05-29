using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Types;

namespace UI.Console.Pages;

public class HomePage : BasePage
{
	public HomePage() : base(
		ComponentId.HomePage,
		PageChildrenFactory.GetHomePageChildren())
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