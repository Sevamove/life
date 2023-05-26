namespace UI.Console.Interfaces;

public interface IForm : IComponent
{
	public void SetInputValues();
	public string[] GetInputValues();
}