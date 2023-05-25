using UI.Console.Enums;

namespace UI.Console.Interfaces;

public interface IRouter
{
	public void SetCurrentPage(Page page);
	public Page GetCurrentPage();
}