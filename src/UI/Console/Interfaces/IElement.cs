using UI.Console.Enums;

namespace UI.Console.Interfaces;

public interface IElement // : IEventTarget
{
	public void Render();
	public ElementId GetElementId();
}