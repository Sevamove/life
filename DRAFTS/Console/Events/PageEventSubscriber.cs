using UI.Console.Enums;

namespace UI.Console.Events;

public class PageEventSubscriber
{
	private Page currentPage;

	// Event handler method
	public void UpdateCurrentPage(Page page)
	{
		this.currentPage = page;
		System.Console.WriteLine("Event handled: " + page);
	}

	public Page GetCurrentPage()
	{
		return this.currentPage;
	}
}