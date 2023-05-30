using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseInput : BaseComponent, IInput
{
	internal readonly string placeholder;

	public BaseInput(ComponentId componentId, IComponent[] childComponents, string placeholder = "") : base(componentId, ElementId.Input, childComponents)
	{
		this.placeholder = placeholder;
	}
}