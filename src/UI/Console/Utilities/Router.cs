using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Utilities;

public class Router : IRouter
{
	private Page currentPage;

	public Router(Page startPage)
	{
		this.currentPage = startPage;
	}

	public void SetCurrentPage(Page currentPage)
	{
		this.currentPage = currentPage;
	}

	public Page GetCurrentPage()
	{
		return this.currentPage;
	}
}