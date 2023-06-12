using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Header;

namespace UI.Console.Components.Headers;

public class MainHeader : BaseHeader
{
	public MainHeader() : base(
		ComponentId.MainHeader,
		HeaderChildrenFactory.GetMainHeaderChildren())
	{
	}
}