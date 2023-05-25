using UI.Console.Types;

namespace UI.Console.Interfaces;

public interface IButton : IComponent
{
	public ClickResult OnClick();
	public string Content();
	public string Title();
}