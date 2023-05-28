using UI.Console.Components.Common;
using UI.Console.Enums;
using UI.Console.Factories.Button;
using UI.Console.Types;

namespace UI.Console.Components.Buttons;

public class QuitGameButton : BaseButton
{
	public QuitGameButton() :
		base(
			ComponentId.QuitGameButton,
			"Quit game",
			$"Type {(int)ComponentId.QuitGameButton} to quit the game.",
			ButtonChildrenFactory.GetQuitGameButtonChildren())
	{
	}

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine("Quit game button clicked!");

		this.componentStorage.IsGameQuit = true;

		return new ComponentResult
		{
			Storage = this.componentStorage
		};
	}
}