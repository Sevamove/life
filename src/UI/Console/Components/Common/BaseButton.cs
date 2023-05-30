using UI.Console.Enums;
using UI.Console.Interfaces;

namespace UI.Console.Components.Common;

public abstract class BaseButton : BaseComponent, IButton
{
	internal readonly string content;
	internal readonly string title;

	// TODO: too many parameters.
	public BaseButton(ComponentId componentId, string content, string title, IComponent[] childComponents) : base(componentId, ElementId.Button, childComponents)
	{
		this.content = content;
		this.title = title;
	}

	// TODO: add ASCII design for a button.
	public override void Render()
	{
		// Note: you would usually display the content of a button.
		// But in this case with the console UI application we want
		// to render a title immediately to give more information
		// to the user.
		// System.Console.WriteLine(this.content);

		System.Console.WriteLine(this.title);
	}

	public string Content()
	{
		return this.content;
	}

	public string Title()
	{
		return this.title;
	}
}