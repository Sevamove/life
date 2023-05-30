using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseNav : BaseComponent, INav
{
	public BaseNav(ComponentId componentId, IComponent[] childComponents) : base(componentId, ElementId.Nav, childComponents)
	{
	}

	public override void Render()
	{
		foreach (var component in this.childComponents)
		{
			component.Render();
		}
	}

	public async override Task<ComponentResult> Execute()
	{
		return await this.GetComponentResult();
	}
}