using UI.Console.Enums;
using UI.Console.Handlers;
using UI.Console.Interfaces;
using UI.Console.Listeners;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseNav : BaseComponent, INav
{
	public BaseNav(ComponentId componentId, IComponent[] childComponents) : base(componentId, ElementId.Nav, childComponents)
	{
	}

	public async override Task<ComponentResult> Execute()
	{
		ComponentId componentId = ComponentListener.Listen(this.GetChildComponents());
		// ComponentResult result = await ComponentHandler.Handle(componentId, this.GetChildComponents());
		return await this.componentHelper.Execute(componentId);

		// return result;
	}
}