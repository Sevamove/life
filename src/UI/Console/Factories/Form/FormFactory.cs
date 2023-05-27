using Application.Interfaces;
using UI.Console.Components.Forms;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Form;

public static class FormFactory
{
	public static IComponent GetNewGameForm(IRestApi restApi)
	{
		return new NewGameForm(restApi);
	}
}