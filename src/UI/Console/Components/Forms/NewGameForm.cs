using Domain.DTO;
using UI.Console.Components.Common;
using UI.Console.Converters;
using UI.Console.Enums;
using UI.Console.Factories.Form;
using UI.Console.Types;

namespace UI.Console.Components.Forms;

public class NewGameForm : BaseForm
{
	public NewGameForm() : base(
		ComponentId.NewGameForm,
		FormChildrenFactory.GetNewGameFormChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		// this.componentHelper.Render(ComponentId.GameNameInput);
		// ComponentResult gameNameResult = await this.componentHelper.Execute(ComponentId.GameNameInput);

		// if (gameNameResult.Storage.Router.Pull() != null)
		// {
		// 	return gameNameResult;
		// }

		// this.componentHelper.Render(ComponentId.GridAreaInput);
		// ComponentResult gridAreaResult = await this.componentHelper.Execute(ComponentId.GridAreaInput);

		// if (gridAreaResult.Storage.Router.Pull() != null)
		// {
		// 	return gridAreaResult;
		// }

		// this.componentHelper.Render(ComponentId.CellPositionInput);
		// ComponentResult cellPositionResult1 = await this.componentHelper.Execute(ComponentId.CellPositionInput);

		// this.componentHelper.Render(ComponentId.CellPositionInput);
		// ComponentResult cellPositionResult2 = await this.componentHelper.Execute(ComponentId.CellPositionInput);

		// this.componentHelper.Render(ComponentId.CellPositionInput);
		// ComponentResult cellPositionResult3 = await this.componentHelper.Execute(ComponentId.CellPositionInput);

		string[] cellPositions = new string[] {
			// cellPositionResult1.Storage.InputValue,
			// cellPositionResult2.Storage.InputValue,
			// cellPositionResult3.Storage.InputValue
			"10-13",
			"10-14",
			"10-15"
		};

		// GameDTO? game = DTOConverter.ConvertToGameDTO("2121312314124", gameNameResult.Storage.InputValue, gridAreaResult.Storage.InputValue, cellPositions);
		GameDTO? game = DTOConverter.ConvertToGameDTO("404", "Game 12122", "20-20", cellPositions);

		// System.Console.WriteLine("Got game " + game.Name + "State " + game.Grid.Cells[0, 0].State);
		// System.Console.WriteLine("Got game " + game.Name + "State " + game.Grid.Cells[10, 13].State);

		if (game == null)
		{
			System.Console.WriteLine("Game is null in new game form");
			throw new Exception("Null game");
		}

		this.componentStorage.Game = await this.restApi.PostGame(game);
		this.componentStorage.Router.Push(Page.Playground);

		System.Console.WriteLine("Successfully saved " + this.componentStorage.Game.Name);

		// for (int i = 0; i < inputs.Length; i++)
		// {
		// 	IInput input = inputs[i];

		// 	input.Render();
		// 	await input.Execute();

		// 	inputValues[i] = input.GetValue();
		// }

		// postGameButton.SetData(inputs);
		// Storage result = await postGameButton.Execute();

		// return result;
		return await base.Execute();
	}

	public override void Render()
	{
		System.Console.WriteLine("# New Game Form");
	}
}