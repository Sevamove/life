using Application;
using Domain.DTO;
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

		GridDTO gridDTO = new GridDTO(
			new AreaDTO(20, 20),
			new CellDTO[] {
				new CellDTO("1", new PositionDTO(10, 10), 1),
				new CellDTO("2", new PositionDTO(10, 11), 1),
				new CellDTO("3", new PositionDTO(10, 12), 1)
		});

		GameDTO gameDTO = new GameDTO(
			"1",
			"My Game",
			gridDTO
		);

		return new ClickResult
		{
			GameDTOs = new GameDTO[] { gameDTO },
			Page = Page.Playground
		};
	}
}