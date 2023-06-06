using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.StackedList;
using UI.Console.Types;
using UI.Console.Validators;

namespace UI.Console.Components.StackedLists;

public class GamesStackedList : BaseStackedList
{
	public GamesStackedList() : base(
		ComponentId.GamesStackedList,
		StackedListChildrenFactory.GetGamesStackedListChildren()
	)
	{ }

	// TODO: refactor.
	public override async Task LoadResourceDependencies()
	{
		await base.LoadResourceDependencies();
		this.componentStorage.Games = await this.restApi.GetGames();

		// TODO: wouldn't it be better to load the patterns with the games from the server at the same time?
		if (this.componentStorage.Games == null)
		{
			this.componentStorage.Games = await this.restApi.GetPatterns();
		}
		else
		{
			this.componentStorage.Games = this.componentStorage.Games.Concat(await this.restApi.GetPatterns()).ToArray();
		}
	}

	public override void Render()
	{
		System.Console.WriteLine("# Games Stacked List");

		if (this.componentStorage.Games == null)
		{
			System.Console.WriteLine("! There are no games saved. Create a new game first or choose a pattern !");
		}
		else
		{
			foreach (var game in this.componentStorage.Games)
			{
				System.Console.WriteLine();
				System.Console.WriteLine("Game Name: " + game.Name);
				System.Console.WriteLine("Grid Width: " + game.Grid.Area.Width);
				System.Console.WriteLine("Grid Height: " + game.Grid.Area.Height);
				System.Console.WriteLine();
			}
			System.Console.Write("> Choose a game and type the name: ");
		}
	}

	// TODO: refactor.
	public override async Task<ComponentResult> Execute()
	{
		if (this.componentStorage.Games != null)
		{
			await base.Execute();

			foreach (var game in this.componentStorage.Games)
			{
				if (game.Name == this.componentStorage.UserInput || game.Id == this.componentStorage.UserInput)
				{
					this.componentStorage.Router.Push(Page.Playground);
					this.componentStorage.Game = game;
				}
			}
		}
		else
		{
			return await base.Execute();
		}

		return await this.GetComponentResult();
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidGamesStackedListUserInput(this.componentStorage.Games, this.componentStorage.UserInput);
	}
}