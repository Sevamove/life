using Application;
using Infrastructure.Enums;
using UI.Console.Components.Common;

namespace UI.Console.Components;

public class NavBar : BaseComponent
{
	private readonly Game game;
	public BaseComponent[] ChildComponents;

	public NavBar(Game game, BaseComponent[] childComponents) : base(ElementId.NavBar)
	{
		this.game = game;
		this.ChildComponents = childComponents;
	}

	public override void Render()
	{
		foreach (var ChildComponent in ChildComponents)
		{
			ChildComponent.Render();
		}
	}
}