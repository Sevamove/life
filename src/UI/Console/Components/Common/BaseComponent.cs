using Application;
using Application.Interfaces;
using Configuration;
using UI.Console.Types;
using UI.Console.Enums;
using UI.Console.Helpers;
using UI.Console.Interfaces;
using UI.Console.Listeners;
using UI.Console.Utilities;
using UI.Console.Validators;

namespace UI.Console.Components.Common;

public abstract class BaseComponent : BaseElement, IComponent
{
	internal readonly IComponentHelper componentHelper;
	internal readonly IRestApi restApi;
	internal readonly IComponent[] childComponents;
	internal Storage componentStorage;

	private readonly ComponentId componentId;
	private int renderDelay;

	protected BaseComponent(ComponentId componentId, ElementId elementId, IComponent[] childComponents, int renderDelay = Timeout.Infinite) : base(elementId)
	{
		this.componentId = componentId;
		this.renderDelay = renderDelay;
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

	public void ResetComponentStorage()
	{
		this.componentStorage.IsAnchorTriggered = false;
	}

	// TODO: Refactor the code and create an executor (based on delegate types) if necessary.
	public async virtual Task<ComponentResult> Execute()
	{
		this.updateComponentStorages();

		while (true)
		{
			string userInput = UserInputListener.Listen(this.renderDelay);
			this.componentStorage.UserInput = userInput;

			if (UserInputValidator.IsValidQuitGameButton(userInput))
			{
				return await Searcher.GetButton(userInput).Execute();
			}

			if (UserInputValidator.IsValidNavBarInputValue(userInput))
			{
				return await Searcher.GetAnchor(userInput).Execute();
			}

			if (this.IsValidUserInput())
			{
				this.ResetComponentStorage();
				this.componentStorage.UserInput = userInput;
				return await this.GetComponentResult();
			}

			if (this.GetComponentId() == ComponentId.GridSection)
			{
				return await this.GetComponentResult();
			}

			System.Console.WriteLine("! You have provided unsupported input. Try again !");
		}
	}

	// TODO: should it be here or somewhere in UserInputValidator?
	public virtual bool IsValidUserInput()
	{
		return false;
	}

	public async virtual Task<ComponentResult> GetComponentResult()
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

	internal void clearConsole()
	{
		if (Config.ShouldClearConsole())
		{
			System.Console.Clear();
		}
	}

	public void SetComponentStorage(Storage storage)
	{
		this.componentStorage = storage;
	}

	public virtual async Task LoadResourceDependencies()
	{
		this.updateComponentStorages();

		foreach (var childComponent in this.childComponents)
		{
			await childComponent.LoadResourceDependencies();
		}
	}
}