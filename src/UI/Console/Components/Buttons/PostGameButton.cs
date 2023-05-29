using Domain.DTO;
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
		// System.Console.WriteLine("Post game button clicked!");

		// // TODO: remove.
		// GameDTO gamea = GameDTOBuilder.GetGameDTO(new GameMock());

		// GameDTO game = await this.restApi.PostGame(gamea);

		// this.componentStorage.Game = game;
		// this.componentStorage.Router.Push(Page.Playground);

		return await this.GetComponentResult();
	}
}