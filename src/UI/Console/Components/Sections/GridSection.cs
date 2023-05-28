using Configuration;
using Domain.DTO;
using Domain.ValueObjects.Cell;
using Infrastructure.Builders.DTO;
using Test.Mocks;
using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Section;
using UI.Console.Types;

namespace UI.Console.Components.Sections;

public class GridSection : BaseSection
{
	public GridSection() : base(
		ComponentId.GridSection,
		SectionChildrenFactory.GetGridSectionChildren())
	{
		// GameDTO gamea = GameDTOBuilder.GetGameDTO(new GameMock());
		// this.game = gamea;
	}

	public override void Render()
	{
		System.Console.WriteLine("Grid rendered.");
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

	public override async Task<ComponentResult> Execute()
	{
		this.componentStorage.Game = await this.restApi.GetGrid(this.componentStorage.Game);

		return await base.Execute();
	}
}