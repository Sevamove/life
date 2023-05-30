using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseForm : BaseComponent, IForm
{
	public BaseForm(ComponentId componentId, IComponent[] childComponents, int renderDelay = Timeout.Infinite) : base(
		componentId,
		ElementId.Form,
		childComponents,
		renderDelay)
	{
	}
}