using Infrastructure.Enums;

namespace UI.Console.Interfaces;

public interface IElement// : IEvent
{
	public ElementId Id();
	public void Render();
}