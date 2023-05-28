using Application;
using Application.Interfaces;
using UI.Console.Enums;
using UI.Console.Helpers;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseComponent : BaseElement, IComponent
{
	internal readonly IComponentHelper componentHelper;
	internal readonly IRestApi restApi;
	internal readonly IComponent[] childComponents;
	internal Storage componentStorage;

	private readonly ComponentId componentId;

	protected BaseComponent(ComponentId componentId, ElementId elementId, IComponent[] childComponents) : base(elementId)
	{
		this.componentId = componentId;
		this.childComponents = childComponents;

		this.componentHelper = new ComponentHelper(this.childComponents);
		this.restApi = new RestApi();
		this.componentStorage = new Storage();
	}

	public ComponentId GetComponentId()
	{
		return this.componentId;
	}

	public IComponent[] GetChildComponents()
	{
		return this.childComponents;
	}

	public void SetComponentStorage(Storage storage)
	{
		this.componentStorage = storage;
	}

	public Storage GetComponentStorage()
	{
		return this.componentStorage;
	}

	public async virtual Task<ComponentResult> Execute()
	{
		return new ComponentResult
		{
			Storage = this.componentStorage
		};
	}

	internal void updateComponentStorages()
	{
		foreach (var childComponent in this.childComponents)
		{
			childComponent.SetComponentStorage(this.componentStorage);
		}
	}
}