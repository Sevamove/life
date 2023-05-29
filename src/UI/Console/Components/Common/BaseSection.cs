using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseSection : BaseComponent, ISection
{
	public BaseSection(ComponentId componentId, IComponent[] childComponents, int renderDelay = Timeout.Infinite) : base(
		componentId,
		ElementId.Section,
		childComponents,
		renderDelay)
	{
	}
}