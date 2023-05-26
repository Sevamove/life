using Application.Interfaces;
using UI.Console.Components.Inputs;
using UI.Console.Interfaces;
using UI.Console.Pages;

namespace UI.Console.Builders;

public class InputsBuilder
{
	public static IInput[] GetAllNewGameFormInputs(IRestApi restApi)
	{
		return new IInput[] {
			new InputWithLabel("Name"),
			new InputWithLabel("Cell position (nr. 1)"),
		};
	}
}