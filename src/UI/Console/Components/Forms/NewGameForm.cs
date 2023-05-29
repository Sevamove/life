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
		this.componentHelper.Render(ComponentId.GameNameInput);
		string gameNameResult = (string)(await this.componentHelper.Execute(ComponentId.GameNameInput)).Storage.UserInput.Clone();

		// if (gameNameResult.Storage.Router.Pull() != Page.NotFound)
		// {
		// 	System.Console.WriteLine(gameNameResult.Storage.Router.Pull());
		// 	return gameNameResult;
		// }

		this.componentHelper.Render(ComponentId.GridAreaInput);
		string gridAreaResult = (string)(await this.componentHelper.Execute(ComponentId.GridAreaInput)).Storage.UserInput.Clone();

		// if (gridAreaResult.Storage.Router.Pull() != Page.NotFound)
		// {
		// 	return gridAreaResult;
		// }

		List<string> cells = new List<string>();

		while (true)
		{
			this.componentHelper.Render(ComponentId.CellPositionInput);
			ComponentResult cellPositionResult = await this.componentHelper.Execute(ComponentId.CellPositionInput);
			System.Console.WriteLine(cellPositionResult.Storage.UserInput);

			cells.Add(cellPositionResult.Storage.UserInput);

			System.Console.WriteLine("Would you like to add more cell positions? (y)es or (n)o");
			string more = System.Console.ReadLine();

			if (more.Equals("n"))
			{
				break;
			}
		}

		System.Console.WriteLine(gameNameResult);
		System.Console.WriteLine(gridAreaResult);
		System.Console.WriteLine(cells[0]);
		System.Console.WriteLine(cells[1]);
		System.Console.WriteLine(cells[2]);

		// string[] cellPositions = new string[] {
		// 	cellPositionResult1.Storage.UserInput,
		// 	cellPositionResult2.Storage.UserInput,
		// 	cellPositionResult3.Storage.UserInput
		// 	// "10-9",
		// 	// "10-10",
		// 	// "10-11",
		// 	// "10-14",
		// 	// "10-15",
		// 	// "10-16",
		// };

		GameDTO? game = DTOConverter.ConvertToGameDTO("NEWNEWEWNE", gameNameResult, gridAreaResult, cells.ToArray());
		// GameDTO? game = DTOConverter.ConvertToGameDTO("404", "Game 12122", "20-20", cellPositions);

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
		return await this.GetComponentResult();
	}

	public override void Render()
	{
		System.Console.WriteLine("# New Game Form");
	}
}