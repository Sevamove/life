using Infrastructure.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseComponent : BaseElement, IComponent
{
	protected BaseComponent(ElementId Id) : base(Id)
	{
	}
}