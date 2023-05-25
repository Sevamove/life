using UI.Console.Components.Common;
using UI.Console.Types;

namespace UI.Console.Handlers;

public class ComponentHandler
{
	public static ClickResult HandleButton(BaseButton button)
	{
		return button.OnClick();
	}
}