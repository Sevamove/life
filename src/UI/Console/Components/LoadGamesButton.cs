using Application;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;

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

	public override void OnClick()
	{
		System.Console.WriteLine("Load game button clicked!");

		// Event.Invoke(this.game.LoadGames());
	}
}