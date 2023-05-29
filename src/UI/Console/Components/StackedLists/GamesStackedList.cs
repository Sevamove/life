using Application;
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

	public override async Task LoadResourceDependencies()
	{
		await base.LoadResourceDependencies();
		this.componentStorage.Games = await new RestApi().GetGames();
	}

	public override void Render()
	{
		System.Console.WriteLine("# Games Stacked List");

		foreach (var game in this.componentStorage.Games)
		{
			System.Console.WriteLine("Game Id: " + game.Id);
			System.Console.WriteLine("Game Name: " + game.Name);
			System.Console.WriteLine();
		}
	}

	// TODO: refactor.
	public override async Task<ComponentResult> Execute()
	{
		this.componentStorage.Router.Push(Page.Playground);

		await base.Execute();

		foreach (var game in this.componentStorage.Games)
		{
			if (game.Name == this.componentStorage.UserInput || game.Id == this.componentStorage.UserInput)
			{
				this.componentStorage.Game = game;
			}
		}

		return await this.GetComponentResult();
	}

	public override bool IsValidUserInput()
	{
		return UserInputValidator.IsValidGamesStackedListUserInput(this.componentStorage.Games, this.componentStorage.UserInput);
	}
}