using Configuration;
using Domain.DTO;
using Domain.ValueObjects.Cell;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Section;
using UI.Console.Types;

namespace UI.Console.Components.Sections;

public class GridSection : BaseSection
{
	public GridSection() : base(
		ComponentId.GridSection,
		SectionChildrenFactory.GetGridSectionChildren(),
		2000)
	{
	}

	public override async Task LoadResourceDependencies()
	{
		await base.LoadResourceDependencies();
		this.componentStorage.Game = await this.restApi.GetGrid(this.componentStorage.Game);
	}

	public override void Render()
	{
		GameDTO game = this.componentStorage.Game;
		AreaDTO area = game.Grid.Area;

		for (int x = 0; x < area.Width; x++)
		{
			for (int y = 0; y < area.Height; y++)
			{
				CellDTO cell = game.Grid.Cells[x, y];

				bool isAliveCell = cell.State == (int)State.LIVE;

				System.Console.Write(isAliveCell ? Config.GetLiveCellIcon() : Config.GetDeadCellIcon());
			}
			System.Console.WriteLine();
		}
		System.Console.WriteLine();
	}

	// TODO: refactor.
	public override async Task<ComponentResult> Execute()
	{
		var result = await base.Execute();

		if (result.Storage.IsAnchorTriggered)
		{
			return result;
		}

		this.componentStorage.Router.Push(Page.Playground);
		this.componentStorage.IsAnchorTriggered = true;

		return await this.GetComponentResult();
	}
}