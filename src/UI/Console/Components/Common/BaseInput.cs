using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Listeners;

namespace UI.Console.Components.Common;

public abstract class BaseInput : BaseComponent, IInput
{
	private string? value = String.Empty;

	public BaseInput(ComponentId componentId) : base(componentId, ElementId.Input, null)
	{
	}

	public string? GetValue()
	{
		return this.value;
	}

	public void SetValue(string placeholder)
	{
		System.Console.Write(placeholder + ": ");

		this.SetValue();
	}

	public void SetValue()
	{
		this.value = UserInputListener.Listen();
	}
}