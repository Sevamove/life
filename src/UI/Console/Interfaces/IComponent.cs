using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponent : IElement
{
	public Task<ComponentResult> Execute();
	public Task<ComponentResult> Execute(ComponentId childComponentId);
	public ComponentId GetComponentId();
	public IComponent[] GetChildComponents();
}