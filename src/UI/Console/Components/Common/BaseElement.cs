using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

// https://developer.mozilla.org/en-US/docs/Web/API/Element
public abstract class BaseElement : IElement
{
	private readonly ElementId elementId;

	// public Action<T> Event;

	public BaseElement(ElementId id)
	{
		this.elementId = id;
	}

	public ElementId GetElementId()
	{
		return this.elementId;
	}

	public abstract void Render();
}