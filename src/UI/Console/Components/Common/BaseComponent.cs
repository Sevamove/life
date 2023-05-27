using Application;
using Application.Interfaces;
using UI.Console.Enums;
using UI.Console.Handlers;
using UI.Console.Helpers;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseComponent : BaseElement, IComponent
{
	internal readonly IComponentHelper componentHelper;
	internal readonly IRestApi restApi;

	private readonly ComponentId componentId;
	private readonly IComponent[] childComponents;

	protected BaseComponent(ComponentId componentId, ElementId elementId, IComponent[] childComponents) : base(elementId)
	{
		this.componentId = componentId;
		this.childComponents = childComponents;

		this.componentHelper = new ComponentHelper(this.childComponents);
		this.restApi = new RestApi();
	}

	public ComponentId GetComponentId()
	{
		return this.componentId;
	}

	public IComponent[] GetChildComponents()
	{
		return this.childComponents;
	}

	public override void Render()
	{
		foreach (var component in this.childComponents)
		{
			component.Render();
		}
	}

	public async virtual Task<ComponentResult> Execute(ComponentId childComponentId)
	{
		// return await ComponentHandler.Handle(childComponentId, this.childComponents);
		if (this.GetComponentId() == componentId)
		{
			return await this.Execute();
		}

		return await ComponentHandler.Handle(componentId, this.GetChildComponents());
	}

	public abstract Task<ComponentResult> Execute();
}