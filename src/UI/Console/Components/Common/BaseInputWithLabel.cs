using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseInputWithLabel : BaseInput
{
	private readonly string label;

	public BaseInputWithLabel(ComponentId componentId, IComponent[] children, string label, string placeholder = "") : base(componentId, children, placeholder)
	{
		this.label = label;
	}

	public override void Render()
	{
		System.Console.WriteLine(this.label);
		System.Console.Write(this.placeholder + ": ");
	}
}