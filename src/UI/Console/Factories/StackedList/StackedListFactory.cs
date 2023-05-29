using UI.Console.Components.StackedLists;
using UI.Console.Interfaces;

namespace UI.Console.Factories.StackedList;

public static class StackedListFactory
{
	public static IComponent[] GetAllStackedLists()
	{
		return new IComponent[] {
			GetGamesStackedList()
		};
	}

	public static IComponent GetGamesStackedList()
	{
		return new GamesStackedList();
	}
}