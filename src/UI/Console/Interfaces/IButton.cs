namespace UI.Console.Interfaces;

public interface IButton<T> : IComponent
{
	// public ButtonResult OnClick();
	public string Content();
	public string Title();
	public void SetData(T data);
}