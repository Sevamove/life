using Application;
using Infrastructure.DTO;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components;

public class LoadGamesButton : BaseButton
{
	private readonly Game game;

	public LoadGamesButton(Game game) : base(
		ElementId.LoadGamesButton,
		"Load grids",
		$"Type {(int)Page.Games} to load a all saved grids.")
	{
		this.game = game;
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Load game button clicked!");

		GameDTO[] gameDTOs = this.game.LoadGames();

		return new ClickResult
		{
			GameDTOs = gameDTOs,
			Page = Page.Playground
		};
	}
}