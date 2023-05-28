using UI.Console.Components.Forms;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Form;

public static class FormFactory
{
	public static IComponent[] GetAllForms()
	{
		return new IComponent[] {
			GetNewGameForm()
		};
	}

	public static IComponent GetNewGameForm()
	{
		return new NewGameForm();
	}
}