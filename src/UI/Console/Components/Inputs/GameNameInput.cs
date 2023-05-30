using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Input;
using UI.Console.Validators;

namespace UI.Console.Components.Inputs;

public class GameNameInput : BaseInputWithLabel
{
	public GameNameInput() : base(
		ComponentId.GameNameInput,
		InputChildrenFactory.GetGameNameInputChildren(),
		"Label: GAME NAME",
		"> Placeholder: What is the name of your new game?")
	{
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidGameNameInputValue(this.componentStorage.UserInput);
	}
}