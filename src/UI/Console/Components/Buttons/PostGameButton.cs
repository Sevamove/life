using Domain.DTO;
using Infrastructure.Builders.DTO;
using Test.Mocks;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Button;
using UI.Console.Types;

namespace UI.Console.Components.Buttons;

public class PostGameButton : BaseButton
{
	private GameDTO game;

	public PostGameButton() : base(
		ComponentId.PostGameButton,
		"Create a new game",
		$"Type {Page.Game_New} to create a new game.",
		ButtonChildrenFactory.GetPostGameButtonChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Post game button clicked!");

		GameDTO gamea = GameDTOBuilder.GetGameDTO(new GameMock());

		GameDTO game = await this.restApi.PostGame(gamea);

		return new ComponentResult
		{
			Game = game,
			Page = Page.Playground
		};
	}

	// TODO: this method consists of a lot of technical debt. Refactor!!!
	// public override void SetData(IInput?[] inputs/*, ComponentId[] componentIds*/)
	// {
	// 	// string gameName = String.Empty;
	// 	// AreaDTO gridArea;

	// 	// for (int i = 0; i < inputs.Length; i++)
	// 	// {
	// 	// 	IInput input = inputs[i];

	// 	// 	if (input.GetComponentId() == ComponentId.GameNameInput)
	// 	// 	{
	// 	// 		gameName = input.GetValue();
	// 	// 	}

	// 	// 	if (input.GetComponentId() == ComponentId.GridAreaInput)
	// 	// 	{
	// 	// 		int width = -1;
	// 	// 		int height = -1;

	// 	// 		int.TryParse(input.GetValue().Split("-")[0], out width);
	// 	// 		int.TryParse(input.GetValue().Split("-")[1], out height);

	// 	// 		gridArea = new AreaDTO(width, height);
	// 	// 	}

	// 	// 	if (input.GetComponentId() == ComponentId.CellPositionInput)
	// 	// 	{
	// 	// 		// string[] cellPositionStrings = input.GetValue()
	// 	// 	}
	// 	// }

	// 	// this.game = data;

	// 	// GameDTO game = new GameDTO(
	// 	// 	"121",
	// 	// 	"Game 121",
	// 	// 	new GridDTO(
	// 	// 		new AreaDTO(20, 20),
	// 	// 		new CellDTO[,] {
	// 	// 			{
	// 	// 				new CellDTO("1", new PositionDTO(5,5), (int)State.LIVE),
	// 	// 				new CellDTO("2", new PositionDTO(5,6), (int)State.LIVE),
	// 	// 				new CellDTO("3", new PositionDTO(5,7), (int)State.LIVE),
	// 	// 			}
	// 	// 		}
	// 	// 	)
	// 	// );

	// 	// this.game = game;

	// 	// for (int i = 0; i < inputs.Length; i++)
	// 	// {
	// 	// 	IInput input = inputs[i];

	// 	// 	for (int j = 0; j< componentIds.Length; j++) {
	// 	// 		ComponentId componentId = componentIds[i];

	// 	// 		if (input.GetComponentId() == componentId) {

	// 	// 		}
	// 	// 	}
	// 	// }
	// 	// Array.Find(inputs, (input) => {
	// 	// 	input.GetComponentId() == 

	// 	// 	});
	// 	// this.game = data;
	// }
}