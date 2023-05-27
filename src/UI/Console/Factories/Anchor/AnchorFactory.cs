using UI.Console.Components.Anchors;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Anchor;

public static class AnchorFactory
{
	public static IComponent GetGoToGameNewPageAnchor()
	{
		return new GoToGameNewPageAnchor();
	}

	public static IComponent GetGoToGamesPageAnchor()
	{
		return new GoToGamesPageAnchor();
	}

	public static IComponent GetGoToHomePageAnchor()
	{
		return new GoToHomePageAnchor();
	}

	public static IComponent GetGoToPlaygroundPageAnchor()
	{
		return new GoToPlaygroundPageAnchor();
	}
}