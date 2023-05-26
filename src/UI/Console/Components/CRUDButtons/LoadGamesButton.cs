// using Application;
// using Domain.DTO;
// using Infrastructure.Enums;
// using UI.Console.Components.Common;
// using UI.Console.Enums;
// using UI.Console.Types;

// namespace UI.Console.Components;

// public class GetGamesButton : BaseButton
// {
// 	private readonly Game game;

// 	public GetGamesButton(Game game) : base(
// 		ElementId.GetGamesButton,
// 		"Load grids",
// 		$"Type {(int)Page.Games} to load a all saved grids.")
// 	{
// 		this.game = game;
// 	}

// 	public override ButtonResult OnClick()
// 	{
// 		System.Console.WriteLine("Load game button clicked!");

// 		GameDTO[] gameDTOs = this.game.GetGames();

// 		return new ButtonResult
// 		{
// 			GameDTOs = gameDTOs,
// 			Page = Page.Playground
// 		};
// 	}
// }