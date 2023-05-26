using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

namespace UI.Console.Helpers;

public class ComponentHelper : IComponentHelper
{
	private readonly IComponent[] childComponents;

	public ComponentHelper(IComponent[] childComponents)
	{
		this.childComponents = childComponents;
	}

	public void Render(ComponentId componentId)
	{
		IComponent? component = Searcher.GetComponent(componentId, this.childComponents);

		component.Render();
	}

	// TODO: technical debt. Refactor!
	public async Task<ComponentResult> Execute(ComponentId componentId)
	{
		IComponent? component = Searcher.GetComponent(componentId, this.childComponents);

		if (component != null)
		{
			return await component.Execute();
		}

		System.Console.WriteLine("Invalid user input provided");

		return new ComponentResult
		{
			ComponentId = ComponentId.InvalidComponentId,
			Page = Page.Home
		};
	}
}