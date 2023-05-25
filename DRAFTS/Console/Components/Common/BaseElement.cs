using Infrastructure.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

// https://developer.mozilla.org/en-US/docs/Web/API/Element
public abstract class BaseElement : IElement
{
	private readonly ElementId id;

	// public Action<T> Event;

	public BaseElement(ElementId id)
	{
		this.id = id;
	}

	public ElementId Id()
	{
		return this.id;
	}

	public abstract void Render();
}