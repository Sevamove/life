using Application;
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
		System.Console.WriteLine("Grid rendered.");
	}
}