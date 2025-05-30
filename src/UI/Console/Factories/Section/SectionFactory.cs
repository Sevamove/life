using UI.Console.Components.Sections;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Section;

public static class SectionFactory
{
	public static IComponent[] GetAllSections()
	{
		return new IComponent[] {
			GetGridSection()
		};
	}

	public static IComponent GetGridSection()
	{
		return new GridSection();
	}
}