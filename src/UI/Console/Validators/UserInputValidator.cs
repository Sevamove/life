using UI.Console.Converters;
using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Utilities;

namespace UI.Console.Validators;

// TODO: implement.
public class UserInputValidator
{
	// TODO: give a better name for the method.
	public static bool IsValidNavBarInputValue(string inputValue)
	{
		ComponentId? componentId = EnumConverter.ConvertToComponentId(inputValue);

		System.Console.WriteLine("1");
		if (componentId == null)
		{
			return false;
		}

		System.Console.WriteLine("1");
		IComponent? navBar = Searcher.GetAnchor((ComponentId)componentId);

		System.Console.WriteLine("1");
		if (navBar == null)
		{
			return false;
		}

		System.Console.WriteLine("1");
		return true;
	}

	// TODO: improve. Will fail acceptatietest.
	public static bool IsValidGameNameInputValue(string inputValue)
	{
		if (inputValue is string)
		{
			return true;
		}

		return false;
	}

	// NOTE: The correct form at the moment: X-Y (e.g. 10-11).
	// TODO: improve. Will fail acceptatietest.
	public static bool IsValidCellPositionInputValue(string inputValue)
	{
		string[] positions = inputValue.Split("-");

		if (positions.Length != 2)
		{
			return false;
		}

		return true;
	}

	// NOTE: The correct form at the moment: WIDTH-HEIGHT (e.g. 20-20).
	// TODO: improve. Will fail acceptatietest.
	public static bool IsValidGridAreaInputValue(string inputValue)
	{
		string[] area = inputValue.Split("-");

		if (area.Length != 2)
		{
			return false;
		}

		return true;
	}
}