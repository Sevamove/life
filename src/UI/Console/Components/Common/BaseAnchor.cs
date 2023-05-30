using UI.Console.Enums;
using UI.Console.Interfaces;
using UI.Console.Types;

namespace UI.Console.Components.Common;

public abstract class BaseAnchor : BaseComponent, IAnchor
{
	internal readonly string content;
	internal readonly string title;
	internal readonly Page href;

	// TODO: too many parameters. Create a struct.
	public BaseAnchor(
		ComponentId componentId,
		string content,
		string title,
		IComponent[] childComponents,
		Page href
	) : base(componentId, ElementId.Anchor, childComponents)
	{
		this.content = content;
		this.title = title;
		this.href = href;
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

	public override async Task<ComponentResult> Execute()
	{
		System.Console.WriteLine($"{this.GetComponentId()} clicked!");

		this.componentStorage.Router.Push(this.href);
		this.componentStorage.IsAnchorTriggered = true;

		return await this.GetComponentResult();
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