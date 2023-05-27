using Application.Interfaces;
using UI.Console.Components.Sections;
using UI.Console.Interfaces;

namespace UI.Console.Factories.Section;

public static class SectionFactory
{
	public static IComponent GetGridSection(IRestApi restApi)
	{
		return new GridSection(restApi);
	}
}