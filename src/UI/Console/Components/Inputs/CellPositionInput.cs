using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Input;
using UI.Console.Validators;

namespace UI.Console.Components.Inputs;

public class CellPositionInput : BaseInputWithLabel
{
	public CellPositionInput() : base(
		ComponentId.CellPositionInput,
		InputChildrenFactory.GetCellPositionInputChildren(),
		"Label: CELL POSITION",
		"> Placeholder: Provide a cell position in the next form ROW-COLUMN (e.g. 10-12)")
	{
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidCellPositionInputValue(this.componentStorage.UserInput);
	}
}