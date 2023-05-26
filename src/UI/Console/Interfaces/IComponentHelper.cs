using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IComponentHelper
{
	public void Render(ComponentId componentId);
	public Task<ComponentResult> Execute(ComponentId componentId);
}