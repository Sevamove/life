using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components.Inputs;

public class InputWithLabel : BaseInput
{
	private readonly string label;
	private readonly string placeholder;

	public InputWithLabel(ComponentId componentId, string label, string placeholder) : base(componentId)
	{
		this.label = label;
		this.placeholder = placeholder;
	}

	public override void Render()
	{
		System.Console.WriteLine(this.label);
	}

	public override async Task<ComponentResult> Execute()
	{
		this.SetValue(this.placeholder);

		return new ComponentResult
		{
			InputValue = this.GetValue()
		};
	}
}