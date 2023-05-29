using UI.Console.Factories.Anchor;
using UI.Console.Factories.Button;
using UI.Console.Interfaces;

namespace UI.Console.Factories.NavBar;

public static class NavBarChildrenFactory
{
	public static IComponent[] GetHomeNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			ButtonFactory.GetQuitGameButton(),
			// new GoToPlaygroundPageAnchor()
		};
	}

	public static IComponent[] GetGameNewNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			AnchorFactory.GetGoToPlaygroundPageAnchor(),
			ButtonFactory.GetQuitGameButton(),
		};
	}

	public static IComponent[] GetGamesNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToPlaygroundPageAnchor(),
			ButtonFactory.GetQuitGameButton(),
		};
	}

	public static IComponent[] GetPlaygroundNavBarChildren()
	{
		return new IComponent[] {
			AnchorFactory.GetGoToHomePageAnchor(),
			AnchorFactory.GetGoToGameNewPageAnchor(),
			AnchorFactory.GetGoToGamesPageAnchor(),
			ButtonFactory.GetQuitGameButton(),
			// new PlayGameButton(),
			// new PauseGameButton()
		};
	}
}