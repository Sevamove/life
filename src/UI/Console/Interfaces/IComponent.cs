using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponent : IElement, IComponentStorage
{
	public Task<ComponentResult> Execute();
	public ComponentId GetComponentId();
	public IComponent[] GetChildComponents();
}