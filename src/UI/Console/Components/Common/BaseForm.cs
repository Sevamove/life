using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Utilities;

namespace UI.Console.Components.Common;

public abstract class BaseForm : BaseComponent, IForm
{
	public BaseForm(ComponentId componentId, IComponent[] childComponents, int renderDelay = Timeout.Infinite) : base(
		componentId,
		ElementId.Form,
		childComponents,
		renderDelay)
	{
	}

	// public void SetInputValues()
	// {
	// 	IInput?[] inputs = Searcher.GetInputs(this.GetChildComponents());

	// 	if (inputs == null)
	// 	{
	// 		throw new Exception("Form does not contain input components");
	// 	}

	// 	for (int i = 0; i < inputs.Length; i++)
	// 	{
	// 		inputs[i].Render();
	// 		inputs[i].Execute();
	// 	}
	// }

	// public string[] GetInputValues()
	// {
	// 	IInput?[] inputs = Searcher.GetInputs(this.GetChildComponents());

	// 	string[] inputValues = new string[inputs.Length];

	// 	for (int i = 0; i < inputs.Length; i++)
	// 	{
	// 		inputValues[i] = inputs[i].GetValue();
	// 	}

	// 	return inputValues;
	// }
}