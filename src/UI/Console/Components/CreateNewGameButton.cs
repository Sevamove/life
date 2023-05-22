using Application;
using Infrastructure.DTO;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;

namespace UI.Console.Components;

public class CreateNewGameButton : BaseButton
{
	private readonly Game game;
	private GameDTO newGame;

	public CreateNewGameButton(Game game) : base(
		ElementId.CreateNewGameButton,
		"Create a new game",
		$"Type {Page.Game_New} to create a new game.")
	{
		this.game = game;
	}

	public void SetNewGame(GameDTO newGame)
	{
		this.newGame = newGame;
	}

	public override void OnClick()
	{
		System.Console.WriteLine("Create new game button clicked!");

		Event.Invoke(this.game.CreateNewGame(this.newGame));
	}
}