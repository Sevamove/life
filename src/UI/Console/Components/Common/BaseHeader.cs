using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseHeader : BaseComponent, IHeader
{
	public BaseHeader(ComponentId componentId, IComponent[] childComponents) : base(componentId, ElementId.Header, childComponents)
	{
	}

	public override void Render()
	{
		foreach (var childComponent in this.GetChildComponents())
		{
			childComponent.Render();
		}
	}
}