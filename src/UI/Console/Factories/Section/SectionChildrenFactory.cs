using Application.Interfaces;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Section;

public static class SectionChildrenFactory
{
	public static IComponent[] GetGridSectionChildren(IRestApi restApi)
	{
		return new IComponent[] {
			// new PlayGameButton(restApi),
			// new PauseGameButton()
		};
	}
}