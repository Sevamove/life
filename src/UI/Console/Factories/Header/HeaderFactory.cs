using UI.Console.Components.Headers;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Header;

public static class HeaderFactory
{
	public static IHeader[] GetAllHeaders()
	{
		return new IHeader[] {
			GetMainHeader()
		};
	}

	public static IHeader GetMainHeader()
	{
		return new MainHeader();
	}
}