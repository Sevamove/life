namespace UI.Console.Interfaces;

public interface IButton : IComponent
{
	// public ButtonResult OnClick();
	public string Content();
	public string Title();
}