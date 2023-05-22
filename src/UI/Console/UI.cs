// using Application;
// using Domain.Entities;
// using Domain.ValueObjects.Cell;
// using UI.Console.Enums;

// namespace UI.Console;

// public interface IUI
// {
// 	public void Clear();
// 	public void Delay();
// 	public void Display(Cell[,] cells);
// 	// public void PauseGame();
// 	public void DisplayMenu();
// 	public void ChooseGrid();
// 	// public void LoadGame();
// 	// public void CreateNewGame();
// 	// public void SaveGame();
// 	// public void DeleteGame();
// 	// public void PlayGame();
// }

// public class UI : IUI
// {
// 	private const string LIVE_CELL_ICON = "🟦";
// 	private const string DEAD_CELL_ICON = "⬜️";
// 	private readonly Area area;
// 	private readonly int fps;

// 	// private bool isGamePlaying;
// 	// private bool isGamePaused;
// 	// private bool hasGameStarted;
// 	private Page Page;

// 	private int gridId;
// 	private readonly Game game;

// 	public UI(int fps, Area area)
// 	{
// 		this.area = area;
// 		this.fps = fps;
// 		this.game = new Game();
// 	}

// 	public void CreateNewGrid()
// 	{
// 		this.game.CreateGrid();
// 	}

// 	public void LoadGrid()
// 	{
// 		GridDTO grid = this.game.LoadGrid();
// 	}

// 	public void SaveGrid()
// 	{
// 		this.game.SaveGrid();
// 	}

// 	public void UpdateGrid()
// 	{
// 		this.game.UpdateGrid();
// 	}

// 	public void Clear()
// 	{
// 		System.Console.Clear();
// 	}

// 	public void Delay()
// 	{
// 		int frameDelay = 1000 / this.fps;

// 		Thread.Sleep(frameDelay);
// 	}

// 	public void Display(Cell[,] cells)
// 	{
// 		for (int x = 0; x < this.area.Width; x++)
// 		{
// 			for (int y = 0; y < this.area.Height; y++)
// 			{
// 				bool isAliveCell = cells[x, y].GetState() == State.LIVE;

// 				System.Console.Write(isAliveCell ? LIVE_CELL_ICON : DEAD_CELL_ICON);
// 			}
// 			System.Console.WriteLine();
// 		}
// 		System.Console.WriteLine();
// 	}

// 	public void DisplayMenu()
// 	{
// 		string? chosenOptionString = String.Empty;
// 		int chosenOptionInt = -1;

// 		switch (this.Page)
// 		{
// 			case Page.Home:
// 				while (true)
// 				{
// 					System.Console.WriteLine($"Type {Page.Create} to create a new grid.");
// 					System.Console.WriteLine($"Type {Page.Load} to load a grid.");
// 					System.Console.WriteLine($"Type {Page.Quit} to quit the game.");

// 					chosenOptionString = System.Console.ReadLine();

// 					bool success = int.TryParse(chosenOptionString, out chosenOptionInt);

// 					if (success)
// 					{
// 						this.Page = (Page)chosenOptionInt;
// 						break;
// 					}

// 					System.Console.WriteLine("Error: chosen option is not valid. Try again.");
// 				}
// 				break;
// 			case Page.Load:
// 				while (true)
// 				{
// 					System.Console.WriteLine($"Type {Page.Home} to go to home.");
// 					System.Console.WriteLine($"Type {Page.Quit} to quit the game.");

// 					chosenOptionString = System.Console.ReadLine();

// 					bool success = int.TryParse(chosenOptionString, out chosenOptionInt);

// 					if (success)
// 					{
// 						this.Page = (Page)chosenOptionInt;
// 						break;
// 					}

// 					System.Console.WriteLine("Error: chosen option is not valid. Try again.");
// 				}
// 				break;
// 			case Page.Play:
// 				while (true)
// 				{
// 					System.Console.WriteLine($"Type {Page.Pause} to pause the game.");
// 					System.Console.WriteLine($"Type {Page.Quit} to quit the game.");

// 					chosenOptionString = System.Console.ReadLine();

// 					bool success = int.TryParse(chosenOptionString, out chosenOptionInt);

// 					if (success)
// 					{
// 						this.Page = (Page)chosenOptionInt;
// 						break;
// 					}

// 					System.Console.WriteLine("Error: chosen option is not valid. Try again.");
// 				}
// 				break;
// 			default:
// 				break;
// 		}
// 	}

// 	public void ChooseGrid()
// 	{
// 		GridDTO[] grids = this.game.LoadGrids();

// 		while (true)
// 		{
// 			System.Console.WriteLine("Choose a grid by id:");

// 			for (int i = 0; i < grids.Length; i++)
// 			{
// 				System.Console.WriteLine("Id: " + grids[i].Id);
// 				System.Console.WriteLine("Name: " + grids[i].Name + "\n");
// 			}

// 			string? gridIdString = System.Console.ReadLine();

// 			bool success = int.TryParse(gridIdString, out this.gridId);

// 			if (success)
// 			{
// 				break;
// 			}

// 			System.Console.WriteLine("Error: entered grid id is invalid. Try again.");
// 		}
// 	}
// }