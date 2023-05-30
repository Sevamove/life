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
}