// using Application;
// using UI.Console.Enums;

// namespace UI.Console.Components;

// public class LoadGridButton : BaseButton<GridDTO>
// {
// 	private readonly Game game;

// 	public LoadGridButton(Game game) : base("Load grid", $"Type {Page.LoadGrid} to load a grid.")
// 	{
// 		this.game = game;
// 	}

// 	public override GridDTO OnClick()
// 	{
// 		return this.game.LoadGrid();
// 	}
// }