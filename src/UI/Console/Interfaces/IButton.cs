namespace UI.Console.Interfaces;

public interface IButton : IComponent
{
	public void OnClick();
	public string Content();
	public string Title();
}