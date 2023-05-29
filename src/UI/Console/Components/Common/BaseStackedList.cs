using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseStackedList : BaseComponent, IStackedList
{
	public BaseStackedList(ComponentId componentId, IComponent[] childComponents, int renderDelay = Timeout.Infinite) : base(
		componentId,
		ElementId.List,
		childComponents,
		renderDelay)
	{
	}

	// TODO: create a new function where you load data from a server in
	// order to render page.

	// TODO: add ASCII design for a button.
	// public override void Render()
	// {
	// 	foreach (var game in this.componentStorage.Games)
	// 	{
	// 		System.Console.WriteLine("Game Id: " + game.Id);
	// 		System.Console.WriteLine("Game Name: " + game.Name);
	// 		System.Console.WriteLine();
	// 	}
	// }

	// public override async Task<ComponentResult> Execute()
	// {
	// 	this.componentStorage.Games = await this.restApi.GetGames();
	// 	this.componentStorage.Router.Push(Page.Games);

	// 	return await base.Execute();
	// }
}