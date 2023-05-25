// using Application;
// using UI.Console.Components.Common;
// using UI.Console.Enums;

// namespace UI.Console.Components;

// public class PauseGameButton : BaseButton<string>
// {
// 	private readonly Game game;

// 	public PauseGameButton(Game game) : base("Pause game", $"Type {Page.PauseGame} to pause the game.")
// 	{
// 		this.game = game;
// 	}

// 	// TODO: find a better solution to handle the return type.
// 	public override string OnClick()
// 	{
// 		System.Console.WriteLine("Enter Space or Return to continue.");
// 		return System.Console.ReadLine();
// 	}
// }