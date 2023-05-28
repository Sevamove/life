using UI.Console.Enums;

namespace UI.Console.Interfaces;

public interface IRouter
{
	public void Push(Page page);
	public Page Pull();
}