using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Listeners;
using UI.Console.Types;
using UI.Console.Utilities;
using UI.Console.Validators;

namespace UI.Console.Components.Common;

public abstract class BaseInput : BaseComponent, IInput
{
	internal readonly string placeholder;

	// TODO: remove.
	private string? value = String.Empty;

	public BaseInput(ComponentId componentId, IComponent[] childComponents, string placeholder = "") : base(componentId, ElementId.Input, childComponents)
	{
		this.placeholder = placeholder;
	}

	// TODO: remove.
	public string? GetValue()
	{
		return this.value;
	}

	// TODO: remove.
	public void SetValue(string placeholder)
	{
		// System.Console.Write(placeholder + ": ");

		// this.SetValue();
	}

	public void SetValue()
	{
		this.value = UserInputListener.Listen();
	}

	public virtual async Task<ComponentResult> Execute()
	{
		this.SetValue();

		if (this.IsValidInputValue())
		{
			return await Searcher.GetAnchor(this.GetValue()).Execute();
		}

		if (UserInputValidator.IsValidCellPositionInputValue(this.GetValue()))
		{
			this.componentStorage.InputValue = this.GetValue();

			return await base.Execute();
		}

		System.Console.WriteLine($"Invalid user input in {this.GetComponentId()}");
		throw new ArgumentNullException("Invalid user input");
	}

	public abstract bool IsValidInputValue();
}