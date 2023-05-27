using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Form;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

namespace UI.Console.Components.Forms;

public class NewGameForm : BaseForm
{
	public NewGameForm() : base(
		ComponentId.NewGameForm,
		FormChildrenFactory.GetNewGameFormChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Hello");
		IInput?[] inputs = Searcher.GetInputs(this.GetChildComponents());
		IButton? postGameButton = Searcher.GetButton(ComponentId.PostGameButton, this.GetChildComponents());

		string[] inputValues = new string[inputs.Length];

		for (int i = 0; i < inputs.Length; i++)
		{
			IInput input = inputs[i];

			input.Execute();

			inputValues[i] = input.GetValue();
		}

		// postGameButton.SetData(inputs);
		ComponentResult result = await postGameButton.Execute();

		return result;
	}

	public override void Render()
	{
		System.Console.WriteLine("# New Game Form");
	}
}