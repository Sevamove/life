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

	// TODO: refactor and reduce amount of code lines.
	public override async Task<ComponentResult> Execute()
	{
		this.componentHelper.Render(ComponentId.GameNameInput);
		var gameNameResult = await this.componentHelper.Execute(ComponentId.GameNameInput);
		string gameNameString = (string)gameNameResult.Storage.UserInput.Clone();

		if (gameNameResult.Storage.IsAnchorTriggered)
		{
			return gameNameResult;
		}

		this.componentHelper.Render(ComponentId.GridAreaInput);
		var gridAreaResult = await this.componentHelper.Execute(ComponentId.GridAreaInput);
		string gridAreaString = (string)gridAreaResult.Storage.UserInput.Clone();

		if (gameNameResult.Storage.IsAnchorTriggered)
		{
			return gridAreaResult;
		}

		List<string> cells = new List<string>();

		while (true)
		{
			this.componentHelper.Render(ComponentId.CellPositionInput);
			ComponentResult cellPositionResult = await this.componentHelper.Execute(ComponentId.CellPositionInput);

			cells.Add(cellPositionResult.Storage.UserInput);

			// System.Console.WriteLine("Would you like to add more cell positions? (y)es or (n)o");
			// string more = System.Console.ReadLine();

			this.componentHelper.Render(ComponentId.MoreCellsInput);
			var moreCellsResult = await this.componentHelper.Execute(ComponentId.MoreCellsInput);
			string moreCellsString = (string)moreCellsResult.Storage.UserInput.Clone();

			if (moreCellsResult.Storage.IsAnchorTriggered)
			{
				return moreCellsResult;
			}

			if (moreCellsString.Equals("n"))
			{
				break;
			}
		}

		// TODO: if id is String.Empty than assign it in the game service.
		GameDTO? game = DTOConverter.ConvertToGameDTO("No id", gameNameString, gridAreaString, cells.ToArray());

		if (game == null)
		{
			System.Console.WriteLine("Game is null in new game form");
			throw new Exception("Null game");
		}

		this.componentStorage.Game = await this.restApi.PostGame(game);
		this.componentStorage.Router.Push(Page.Playground);

		System.Console.WriteLine("Successfully saved " + this.componentStorage.Game.Name);

		return await this.GetComponentResult();
	}

	public override void Render()
	{
		System.Console.WriteLine("\n" + "# New Game Form" + "\n");
	}
}