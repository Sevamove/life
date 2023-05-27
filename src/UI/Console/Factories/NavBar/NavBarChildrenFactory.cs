using UI.Console.Factories.Anchor;
using UI.Console.Interfaces;

namespace UI.Console.Factories.NavBar;

public static class NavBarChildrenFactory
{
	public static IComponent[] GetHomeNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			// new GoToPlaygroundPageAnchor()
		};
	}

	public static IComponent[] GetGameNewNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			AnchorFactory.GetGoToPlaygroundPageAnchor()
		};
	}

	public static IComponent[] GetGamesNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToPlaygroundPageAnchor()
		};
	}

	public static IComponent[] GetPlaygroundNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			// new PlayGameButton(),
			// new PauseGameButton()
		};
	}
}