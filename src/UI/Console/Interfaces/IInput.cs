namespace UI.Console.Interfaces;

public interface IInput : IComponent
{
	public void SetValue();
	public void SetValue(string placeholder);
	public string? GetValue();
}