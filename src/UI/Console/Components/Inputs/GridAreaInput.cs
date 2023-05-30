using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Input;
using UI.Console.Validators;

namespace UI.Console.Components.Inputs;

public class GridAreaInput : BaseInputWithLabel
{
	public GridAreaInput() : base(
		ComponentId.GridAreaInput,
		InputChildrenFactory.GetGridAreaInputChildren(),
		"Label: GRID AREA",
		"> Placeholder: Provide the grid area in the next form WIDTH-HEIGHT (minimum 20-20)")
	{
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidGridAreaInputValue(this.componentStorage.UserInput);
	}
}