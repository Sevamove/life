using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Page;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

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
		this.updateComponentStorages();
		this.componentHelper.Render(ComponentId.PlaygroundNavBar);
	}

	public async override Task<ComponentResult> Execute()
	{
		this.updateComponentStorages();
		System.Console.WriteLine(Searcher.GetComponent(ComponentId.GridSection, this.childComponents).GetComponentStorage().Game.Name);

		// await this.componentHelper.Execute(ComponentId.GridSection);
		// this.componentHelper.Render(ComponentId.GridSection);
		// await this.componentHelper.Execute(ComponentId.GridSection);
		// this.componentHelper.Render(ComponentId.GridSection);

		return await this.componentHelper.Execute(ComponentId.GridSection);
	}
}