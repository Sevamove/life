using Infrastructure.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

// https://developer.mozilla.org/en-US/docs/Web/API/Element
public abstract class BaseElement : IElement
{
	public ElementId Id;

	// public Action<T> Event;

	public BaseElement(ElementId Id)
	{
		this.Id = Id;
	}

	// public abstract void OnClick();

	public abstract void Render();
}