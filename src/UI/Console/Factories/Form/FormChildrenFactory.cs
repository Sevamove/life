using Application.Interfaces;
using UI.Console.Factories.Button;
using UI.Console.Factories.Input;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Form;

public static class FormChildrenFactory
{
	public static IComponent[] GetNewGameFormChildren(IRestApi restApi)
	{
		return new IComponent[] {
			InputFactory.GetGameNameInput(),
			InputFactory.GetCellPositionInput(),
			InputFactory.GetGridAreaInput(),
			ButtonFactory.GetPostGameButton(restApi)
		};
	}
}