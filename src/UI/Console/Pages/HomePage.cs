using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Pages;

public class HomePage : BasePage
{
	public HomePage() : base(
		ComponentId.HomePage,
		ComponentsFactory.GetHomePageChildComponents())
	{
	}

	public override void Render()
	{
		this.componentHelper.Render(ComponentId.HomeNavBar);
	}

	public async override Task<ComponentResult> Execute()
	{
		ComponentResult navBarResult = await this.componentHelper.Execute(ComponentId.HomeNavBar);

		return navBarResult;
	}
}