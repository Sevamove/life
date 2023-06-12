using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Input;
using UI.Console.Validators;

namespace UI.Console.Components.Inputs;

public class MoreCellsInput : BaseInputWithLabel
{
	public MoreCellsInput() : base(
		ComponentId.MoreCellsInput,
		InputChildrenFactory.GetMoreCellsInputChildren(),
		"MORE CELLS",
		"Would you like to add more cells? (y)es or (n)o")
	{
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidMoreCellsInputValue(this.componentStorage.UserInput);
	}
}