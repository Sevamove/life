using Application;
using Domain.Aggregates;
using Domain.DTO;
using Infrastructure.Enums;
using UI.Console.Components.Common;

namespace UI.Console.Components;

public class GridSection : BaseComponent
{
	private readonly Game game;

	public GridSection(Game game) : base(ElementId.GridSection)
	{
		this.game = game;
	}

	public override void Render()
	{
		// TODO: temporary use of Grid class. Do we need a memory DB?
		Grid grid = new Grid()
		System.Console.WriteLine("Grid rendered.");
	}
}