using UI.Console.Enums;

namespace UI.Console.Converters;

public class EnumConverter
{
	public static ComponentId? ConvertToComponentId(string stringValue)
	{
		var componentIds = Enum.GetValues(typeof(ComponentId));

		foreach (ComponentId componentId in componentIds)
		{
			int parsedInputValue = -1;

			bool success = int.TryParse(stringValue, out parsedInputValue);

			// TODO: too nested.
			if (success)
			{
				// TODO: create EqualsTo() method in ComponentId enum.
				if ((int)componentId == parsedInputValue)
				{
					return componentId;
				}
			}
		}

		return null;
	}
}