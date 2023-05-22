using UI.Console.Enums;

namespace UI.Console.Utilities;

// TODO: change name to Router
public class Route
{
	private Page currentPage;

	public Route(Page startPage)
	{
		this.currentPage = startPage;
	}

	public void SetCurrentPage(Page currentPage)
	{
		this.currentPage = currentPage;
	}

	public Page GetCurrentpage()
	{
		return this.currentPage;
	}
}