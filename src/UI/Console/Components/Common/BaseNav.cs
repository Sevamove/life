using UI.Console.Enums;
using UI.Console.Handlers;
using UI.Console.Interfaces;
using UI.Console.Listeners;
using UI.Console.Types;
using UI.Console.Utilities;
using UI.Console.Validators;

namespace UI.Console.Components.Common;

public abstract class BaseNav : BaseComponent, INav
{
	public BaseNav(ComponentId componentId, IComponent[] childComponents) : base(componentId, ElementId.Nav, childComponents)
	{
	}

	public override void Render()
	{
		foreach (var component in this.childComponents)
		{
			component.Render();
		}
	}

	public async override Task<ComponentResult> Execute()
	{
		// ComponentId componentId = ComponentListener.Listen(this.GetChildComponents());
		// Storage result = await ComponentHandler.Handle(componentId, this.GetChildComponents());
		// return await this.componentHelper.Execute(componentId);
		string userInput = UserInputListener.Listen();

		if (UserInputValidator.IsValidNavBarInputValue(userInput))
		{
			System.Console.WriteLine("NavBar execute");
			return await Searcher.GetAnchor(userInput).Execute();
		}

		System.Console.WriteLine("Invalid user input in base nav");

		return new ComponentResult();
		throw new ArgumentNullException("Invalid user input");
	}
}