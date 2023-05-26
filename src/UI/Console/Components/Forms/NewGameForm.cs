using Application.Interfaces;
using UI.Console.Components.Common;
using UI.Console.Components.Factories;
using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;
using UI.Console.Utilities;

namespace UI.Console.Components.Forms;

public class NewGameForm : BaseForm
{
	public NewGameForm(IRestApi restApi) : base(
		ComponentId.NewGameForm,
		ComponentsFactory.GetNewGameFormChildComponents(restApi))
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Hello");
		IInput?[] inputs = Searcher.GetInputs(this.GetChildComponents());
		IButton<IInput?[]>? postGameButton = Searcher.GetButton<IInput?[]>(ComponentId.PostGameButton, this.GetChildComponents());

		string[] inputValues = new string[inputs.Length];

		for (int i = 0; i < inputs.Length; i++)
		{
			IInput input = inputs[i];

			input.Execute();

			inputValues[i] = input.GetValue();
		}

		postGameButton.SetData(inputs);
		ComponentResult result = await postGameButton.Execute();

		return result;
	}

	public override void Render()
	{
		System.Console.WriteLine("# New Game Form");
	}
}