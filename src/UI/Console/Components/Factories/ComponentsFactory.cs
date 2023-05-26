using Application.Interfaces;
using UI.Console.Components.Forms;
using UI.Console.Components.GoToButtons;
using UI.Console.Components.Inputs;
using UI.Console.Components.NavBars;
using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Factories;

public class ComponentsFactory
{
	public static IComponent[] GetHomePageChildComponents()
	{
		IComponent[] components = new IComponent[] {
			new HomeNavBar()
		};

		return components;
	}

	public static IComponent[] GetGamesPageChildComponents(IRestApi restApi)
	{
		IComponent[] components = new IComponent[] {
			new GamesNavBar()
		};

		return components;
	}

	public static IComponent[] GetPlaygroundPageChildComponents(IRestApi restApi)
	{
		IComponent[] components = new IComponent[] {
			new PlaygroundNavBar()
			// new GridSection(restApi)
		};

		return components;
	}

	public static IComponent[] GetGridSectionChildComponents(IRestApi restApi)
	{
		IComponent[] components = new IComponent[] {
			// new PlayGameButton(restApi),
			// new PauseGameButton()
		};

		return components;
	}

	public static IComponent[] GetNewGameFormChildComponents(IRestApi restApi)
	{
		IComponent[] formInputs = new IComponent[] {
			new InputWithLabel(ComponentId.GameNameInput, "Game name", "What is the name of your new game"),
			new InputWithLabel(ComponentId.CellPositionInput, "Cell position (nr. 1)", "Provide a cell position in this form ROW-COLUMN (e.g. 10-12)"),
			new InputWithLabel(ComponentId.GridAreaInput, "Grid area", "Provide the grid area in the next form WIDTH-HEIGHT (e.g. 20-20)"),
			new PostGameButton(restApi)
		};

		return formInputs;
	}

	public static IComponent[] GetGameNewPageChildComponents(IRestApi restApi)
	{
		IComponent[] components = new IComponent[] {
			new GameNewNavBar()
			// new NewGameForm(restApi),
		};

		return components;
	}

	public static IComponent[] GetHomeNavBarChildComponents()
	{
		IComponent[] components = new IComponent[] {
			new GoToGameNewPageAnchor(),
			new GoToGamesPageAnchor(),
			new GoToPlaygroundPageAnchor()
		};

		return components;
	}

	public static IComponent[] GetGameNewNavBarChildComponents()
	{
		IComponent[] components = new IComponent[] {
			new GoToHomePageAnchor(),
			new GoToGamesPageAnchor(),
			new GoToPlaygroundPageAnchor()
		};

		return components;
	}

	public static IComponent[] GetGamesNavBarChildComponents()
	{
		IComponent[] components = new IComponent[] {
			new GoToHomePageAnchor(),
			new GoToGameNewPageAnchor(),
			new GoToPlaygroundPageAnchor()
		};

		return components;
	}

	public static IComponent[] GetPlaygroundNavBarChildComponents()
	{
		IComponent[] components = new IComponent[] {
			new GoToHomePageAnchor(),
			new GoToGameNewPageAnchor(),
			new GoToGamesPageAnchor(),
			// new PlayGameButton(),
			// new PauseGameButton()
		};

		return components;
	}

	public static IComponent[] GetPostGameButtonChildComponents()
	{
		IComponent[] components = new IComponent[] { };

		return components;
	}

	public static IComponent[] GetGoToGameNewPageAnchorChildComponents()
	{
		IComponent[] components = new IComponent[] { };

		return components;
	}

	public static IComponent[] GetGoToHomePageAnchorChildComponents()
	{
		IComponent[] components = new IComponent[] { };

		return components;
	}

	public static IComponent[] GetGoToPlaygroundPageAnchorChildComponents()
	{
		IComponent[] components = new IComponent[] { };

		return components;
	}

	public static IComponent[] GetGoToGamesPageAnchorChildComponents()
	{
		IComponent[] components = new IComponent[] { };

		return components;
	}



	// public static IComponent[] GetNewGameFormChildComponents()
	// {
	// 	IInput[] formInputs = new IInput[] {
	// 		new InputWithLabel("Game name", "What is the name of your new game"),
	// 		new InputWithLabel("Cell position (nr. 1)", "Provide a cell position in this form ROW-COLUMN (e.g. 10-12)"),
	// 	};

	// 	IComponent[] components = new IComponent[] {
	// 		// NavBarFactory.GetGameNewNavBar(restApi)
	// 		new NewGameForm(formInputs)
	// 	};

	// 	return components;
	// }

	// public static BaseComponent[] GetGamesPageComponents(Game game)
	// {
	// 	BaseComponent[] components = new BaseComponent[] {
	// 		NavBarFactory.GetGamesNavBar(game)
	// 	};

	// 	return components;
	// }


}