using UI.Console.Interfaces;

namespace UI.Console.Factories.Section;

public static class SectionChildrenFactory
{
	public static IComponent[] GetGridSectionChildren()
	{
		return new IComponent[] {
			// new PlayGameButton(restApi),
			// new PauseGameButton()
		};
	}
}