using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Utilities;

// TODO: Modify the class to accept a generic type instead of the specific type 'Page'.
public class Router : IRouter
{
	private Page currentPage;

	public Router()
	{
		this.currentPage = Page.Home;
	}

	public void Push(Page currentPage)
	{
		this.currentPage = currentPage;
	}

	public Page Pull()
	{
		return this.currentPage;
	}
}