using Application;
using Infrastructure.Enums;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Types;

namespace UI.Console.Components;

public class CreateNewGameButton : BaseButton
{
	private readonly Game game;

	public CreateNewGameButton(Game game) : base(
		ElementId.CreateNewGameButton,
		"Create a new game",
		$"Type {Page.Game_New} to create a new game.")
	{
		this.game = game;
	}

	public override ClickResult OnClick()
	{
		System.Console.WriteLine("Create new game button clicked!");

		return new ClickResult
		{
			GameDTOs = null,
			Page = Page.Game_New
		};
	}
}